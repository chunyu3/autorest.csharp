// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> The CreateCompletionRequestModel. </summary>
    public readonly partial struct CreateCompletionRequestModel : IEquatable<CreateCompletionRequestModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateCompletionRequestModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateCompletionRequestModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Babbage002Value = "babbage-002";
        private const string Davinci002Value = "davinci-002";
        private const string TextDavinci003Value = "text-davinci-003";
        private const string TextDavinci002Value = "text-davinci-002";
        private const string TextDavinci001Value = "text-davinci-001";
        private const string CodeDavinci002Value = "code-davinci-002";
        private const string TextCurie001Value = "text-curie-001";
        private const string TextBabbage001Value = "text-babbage-001";
        private const string TextAda001Value = "text-ada-001";

        /// <summary> babbage-002. </summary>
        public static CreateCompletionRequestModel Babbage002 { get; } = new CreateCompletionRequestModel(Babbage002Value);
        /// <summary> davinci-002. </summary>
        public static CreateCompletionRequestModel Davinci002 { get; } = new CreateCompletionRequestModel(Davinci002Value);
        /// <summary> text-davinci-003. </summary>
        public static CreateCompletionRequestModel TextDavinci003 { get; } = new CreateCompletionRequestModel(TextDavinci003Value);
        /// <summary> text-davinci-002. </summary>
        public static CreateCompletionRequestModel TextDavinci002 { get; } = new CreateCompletionRequestModel(TextDavinci002Value);
        /// <summary> text-davinci-001. </summary>
        public static CreateCompletionRequestModel TextDavinci001 { get; } = new CreateCompletionRequestModel(TextDavinci001Value);
        /// <summary> code-davinci-002. </summary>
        public static CreateCompletionRequestModel CodeDavinci002 { get; } = new CreateCompletionRequestModel(CodeDavinci002Value);
        /// <summary> text-curie-001. </summary>
        public static CreateCompletionRequestModel TextCurie001 { get; } = new CreateCompletionRequestModel(TextCurie001Value);
        /// <summary> text-babbage-001. </summary>
        public static CreateCompletionRequestModel TextBabbage001 { get; } = new CreateCompletionRequestModel(TextBabbage001Value);
        /// <summary> text-ada-001. </summary>
        public static CreateCompletionRequestModel TextAda001 { get; } = new CreateCompletionRequestModel(TextAda001Value);
        /// <summary> Determines if two <see cref="CreateCompletionRequestModel"/> values are the same. </summary>
        public static bool operator ==(CreateCompletionRequestModel left, CreateCompletionRequestModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateCompletionRequestModel"/> values are not the same. </summary>
        public static bool operator !=(CreateCompletionRequestModel left, CreateCompletionRequestModel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CreateCompletionRequestModel"/>. </summary>
        public static implicit operator CreateCompletionRequestModel(string value) => new CreateCompletionRequestModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateCompletionRequestModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateCompletionRequestModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}