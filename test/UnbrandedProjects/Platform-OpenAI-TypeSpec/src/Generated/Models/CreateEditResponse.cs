// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.ClientModel.Internal;

namespace OpenAI.Models
{
    /// <summary> The CreateEditResponse. </summary>
    [Obsolete("deprecated")]
    public partial class CreateEditResponse
    {
        /// <summary> Initializes a new instance of CreateEditResponse. </summary>
        /// <param name="created"> The Unix timestamp (in seconds) of when the edit was created. </param>
        /// <param name="choices"> description: A list of edit choices. Can be more than one if `n` is greater than 1. </param>
        /// <param name="usage"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="choices"/> or <paramref name="usage"/> is null. </exception>
        internal CreateEditResponse(DateTimeOffset created, IEnumerable<CreateEditResponseChoice> choices, CompletionUsage usage)
        {
            ClientUtilities.AssertNotNull(choices, nameof(choices));
            ClientUtilities.AssertNotNull(usage, nameof(usage));

            Created = created;
            Choices = choices.ToList();
            Usage = usage;
        }

        /// <summary> Initializes a new instance of CreateEditResponse. </summary>
        /// <param name="object"> The object type, which is always `edit`. </param>
        /// <param name="created"> The Unix timestamp (in seconds) of when the edit was created. </param>
        /// <param name="choices"> description: A list of edit choices. Can be more than one if `n` is greater than 1. </param>
        /// <param name="usage"></param>
        internal CreateEditResponse(CreateEditResponseObject @object, DateTimeOffset created, IReadOnlyList<CreateEditResponseChoice> choices, CompletionUsage usage)
        {
            Object = @object;
            Created = created;
            Choices = choices;
            Usage = usage;
        }

        /// <summary> The object type, which is always `edit`. </summary>
        public CreateEditResponseObject Object { get; } = CreateEditResponseObject.Edit;

        /// <summary> The Unix timestamp (in seconds) of when the edit was created. </summary>
        public DateTimeOffset Created { get; }
        /// <summary> description: A list of edit choices. Can be more than one if `n` is greater than 1. </summary>
        public IReadOnlyList<CreateEditResponseChoice> Choices { get; }
        /// <summary> Gets the usage. </summary>
        public CompletionUsage Usage { get; }
    }
}
