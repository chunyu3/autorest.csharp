// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Models
{
    /// <summary> The FineTuneEvent. </summary>
    public partial class FineTuneEvent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FineTuneEvent"/>. </summary>
        /// <param name="object"></param>
        /// <param name="createdAt"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="object"/>, <paramref name="level"/> or <paramref name="message"/> is null. </exception>
        internal FineTuneEvent(string @object, DateTimeOffset createdAt, string level, string message)
        {
            if (@object == null)
            {
                throw new ArgumentNullException(nameof(@object));
            }
            if (level == null)
            {
                throw new ArgumentNullException(nameof(level));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Object = @object;
            CreatedAt = createdAt;
            Level = level;
            Message = message;
        }

        /// <summary> Initializes a new instance of <see cref="FineTuneEvent"/>. </summary>
        /// <param name="object"></param>
        /// <param name="createdAt"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FineTuneEvent(string @object, DateTimeOffset createdAt, string level, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Object = @object;
            CreatedAt = createdAt;
            Level = level;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FineTuneEvent"/> for deserialization. </summary>
        internal FineTuneEvent()
        {
        }

        /// <summary> Gets the object. </summary>
        public string Object { get; }
        /// <summary> Gets the created at. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> Gets the level. </summary>
        public string Level { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
    }
}
