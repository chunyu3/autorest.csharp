// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    /// <summary> Defines a function that boosts scores based on the value of a date-time field. </summary>
    public partial class FreshnessScoringFunction : ScoringFunction
    {
        /// <summary> Initializes a new instance of <see cref="FreshnessScoringFunction"/>. </summary>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <param name="parameters"> Parameter values for the freshness scoring function. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fieldName"/> or <paramref name="parameters"/> is null. </exception>
        public FreshnessScoringFunction(string fieldName, double boost, FreshnessScoringParameters parameters) : base(fieldName, boost)
        {
            if (fieldName == null)
            {
                throw new ArgumentNullException(nameof(fieldName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Type = "freshness";
        }

        /// <summary> Initializes a new instance of <see cref="FreshnessScoringFunction"/>. </summary>
        /// <param name="type"> Indicates the type of function to use. Valid values include magnitude, freshness, distance, and tag. The function type must be lower case. </param>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <param name="interpolation"> A value indicating how boosting will be interpolated across document scores; defaults to "Linear". </param>
        /// <param name="parameters"> Parameter values for the freshness scoring function. </param>
        internal FreshnessScoringFunction(string type, string fieldName, double boost, ScoringFunctionInterpolation? interpolation, FreshnessScoringParameters parameters) : base(type, fieldName, boost, interpolation)
        {
            Parameters = parameters;
            Type = type ?? "freshness";
        }

        /// <summary> Parameter values for the freshness scoring function. </summary>
        public FreshnessScoringParameters Parameters { get; set; }
    }
}
