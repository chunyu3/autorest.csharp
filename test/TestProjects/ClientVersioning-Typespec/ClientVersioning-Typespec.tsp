import "@typespec/rest";
import "@typespec/http";
import "@typespec/openapi";
import "@azure-tools/typespec-client-generator-core";
import "@azure-tools/typespec-azure-core";

@versioned(Versions)
@service({title: "Anomaly Detector"})
@useAuth(ApiKeyAuth<ApiKeyLocation.header, "Ocp-Apim-Subscription-Key">)
@server(
  "{Endpoint}/",
  "mulitple version service.",
  {
    @doc("Supported Services endpoints.")
    Endpoint: string  
  }
)
@doc("CADL project to test api versions.")
namespace TestService;

using TypeSpec.Http;
using Azure.ClientGenerator.Core;
using Azure.Core;

enum Versions {
  v1_0: "v1.0",
  v1_1: "v1.1",
  v1_2: "v1.2"
}

@doc("add a model")
@added(Versions.v1_0)
model Foo {
  name: string;
  @added(Versions.v1_2)
  addedOptionalInV12?: string;
}

@doc("add a model")
@added(Versions.v1_0)
model Foo2 {
  name: string;
  @added(Versions.v1_2)
  addedRequiredInV12: string;
}
op opv10(): void

@doc("add a operation.")
@addded(Versions.v1_1)
op opv11(): void

@doc("delete a operation")
@deleted(Versions.v1_1)
op opvdeleted(): void

#updated operation
@deleted(Versions.v1_1)
op opToupdate(): void

@added(Versionsv1_1)
op opToupdate(@path id: string): void

@doc("add a path parameter")
op opToupdated(@added(Versions.v1_1) @path id: string): void