import {
    Enum,
    EnumMember,
    Model,
    ModelProperty,
    Namespace,
    Operation,
    Scalar,
    Type,
    isNullType
} from "@typespec/compiler";
import {
    SdkContext,
    getLibraryName,
    getSdkModel
} from "@azure-tools/typespec-client-generator-core";
import { InputParameter } from "../type/input-parameter.js";
import { InputPrimitiveType, InputType } from "../type/input-type.js";
import { InputPrimitiveTypeKind } from "../type/input-primitive-type-kind.js";
import { RequestLocation } from "../type/request-location.js";
import { InputOperationParameterKind } from "../type/input-operation-parameter-kind.js";
import { InputConstant } from "../type/input-constant.js";
import { InputTypeKind } from "../type/input-type-kind.js";

export function capitalize(str: string): string {
    return str.charAt(0).toUpperCase() + str.slice(1);
}

export function getNameForTemplate(model: Model): string {
    if (
        model.name !== "" &&
        model.templateMapper &&
        model.templateMapper.args
    ) {
        return (
            model.name +
            model.templateMapper.args.map((it) => (it as Model).name).join("")
        );
    }

    return model.name;
}

export function getTypeName(
    context: SdkContext,
    type: Model | Enum | EnumMember | ModelProperty | Scalar | Operation
): string {
    const name = getLibraryName(context, type);
    if (type.kind !== "Model") return name;
    if (type.name === name) {
        const templateName = getNameForTemplate(type);
        if (templateName === "") {
            const sdkModel = getSdkModel(context, type as Model);
            return sdkModel.name;
        }
        return templateName;
    }
    return name;
}

export function getFullNamespaceString(
    namespace: Namespace | undefined
): string {
    if (!namespace || !namespace.name) {
        return "";
    }

    let namespaceString: string = namespace.name;
    let current: Namespace | undefined = namespace.namespace;
    while (current && current.name) {
        namespaceString = `${current.name}.${namespaceString}`;
        current = current.namespace;
    }
    return namespaceString;
}

export function createContentTypeOrAcceptParameter(
    mediaTypes: string[],
    name: string,
    nameInRequest: string
): InputParameter {
    const isContentType: boolean =
        nameInRequest.toLowerCase() === "content-type";
    const inputType: InputType = {
        Kind: InputTypeKind.Primitive,
        Name: InputPrimitiveTypeKind.String,
        IsNullable: false
    } as InputPrimitiveType;
    return {
        Name: name,
        NameInRequest: nameInRequest,
        Type: inputType,
        Location: RequestLocation.Header,
        IsApiVersion: false,
        IsResourceParameter: false,
        IsContentType: isContentType,
        IsRequired: true,
        IsEndpoint: false,
        SkipUrlEncoding: false,
        Explode: false,
        Kind: InputOperationParameterKind.Constant,
        DefaultValue:
            mediaTypes.length === 1
                ? ({
                      Type: inputType,
                      Value: mediaTypes[0]
                  } as InputConstant)
                : undefined
    } as InputParameter;
}

/** TODO: remove when adopt TCGC getAllOperations
 * or when tcgc export isNullable api.
 */
export function isNullable(type: Type) {
    if (type.kind === "Union") {
        const NonNullableOptions = [...type.variants.values()]
            .map((x) => x.type)
            .filter((t) => !isNullType(t));
        if (NonNullableOptions.length < type.variants.size) return true;
    }
    return false;
}
