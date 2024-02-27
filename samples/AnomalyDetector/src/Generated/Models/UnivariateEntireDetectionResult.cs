// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace AnomalyDetector.Models
{
    /// <summary> The response of entire anomaly detection. </summary>
    public partial class UnivariateEntireDetectionResult
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

        /// <summary> Initializes a new instance of <see cref="UnivariateEntireDetectionResult"/>. </summary>
        /// <param name="period">
        /// Frequency extracted from the series, zero means no recurrent pattern has been
        /// found.
        /// </param>
        /// <param name="expectedValues">
        /// ExpectedValues contain expected value for each input point. The index of the
        /// array is consistent with the input series.
        /// </param>
        /// <param name="upperMargins">
        /// UpperMargins contain upper margin of each input point. UpperMargin is used to
        /// calculate upperBoundary, which equals to expectedValue + (100 -
        /// marginScale)*upperMargin. Anomalies in response can be filtered by
        /// upperBoundary and lowerBoundary. By adjusting marginScale value, less
        /// significant anomalies can be filtered in client side. The index of the array is
        /// consistent with the input series.
        /// </param>
        /// <param name="lowerMargins">
        /// LowerMargins contain lower margin of each input point. LowerMargin is used to
        /// calculate lowerBoundary, which equals to expectedValue - (100 -
        /// marginScale)*lowerMargin. Points between the boundary can be marked as normal
        /// ones in client side. The index of the array is consistent with the input
        /// series.
        /// </param>
        /// <param name="isAnomaly">
        /// IsAnomaly contains anomaly properties for each input point. True means an
        /// anomaly either negative or positive has been detected. The index of the array
        /// is consistent with the input series.
        /// </param>
        /// <param name="isNegativeAnomaly">
        /// IsNegativeAnomaly contains anomaly status in negative direction for each input
        /// point. True means a negative anomaly has been detected. A negative anomaly
        /// means the point is detected as an anomaly and its real value is smaller than
        /// the expected one. The index of the array is consistent with the input series.
        /// </param>
        /// <param name="isPositiveAnomaly">
        /// IsPositiveAnomaly contain anomaly status in positive direction for each input
        /// point. True means a positive anomaly has been detected. A positive anomaly
        /// means the point is detected as an anomaly and its real value is larger than the
        /// expected one. The index of the array is consistent with the input series.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expectedValues"/>, <paramref name="upperMargins"/>, <paramref name="lowerMargins"/>, <paramref name="isAnomaly"/>, <paramref name="isNegativeAnomaly"/> or <paramref name="isPositiveAnomaly"/> is null. </exception>
        internal UnivariateEntireDetectionResult(int period, IEnumerable<float> expectedValues, IEnumerable<float> upperMargins, IEnumerable<float> lowerMargins, IEnumerable<bool> isAnomaly, IEnumerable<bool> isNegativeAnomaly, IEnumerable<bool> isPositiveAnomaly)
        {
            if (expectedValues == null)
            {
                throw new ArgumentNullException(nameof(expectedValues));
            }
            if (upperMargins == null)
            {
                throw new ArgumentNullException(nameof(upperMargins));
            }
            if (lowerMargins == null)
            {
                throw new ArgumentNullException(nameof(lowerMargins));
            }
            if (isAnomaly == null)
            {
                throw new ArgumentNullException(nameof(isAnomaly));
            }
            if (isNegativeAnomaly == null)
            {
                throw new ArgumentNullException(nameof(isNegativeAnomaly));
            }
            if (isPositiveAnomaly == null)
            {
                throw new ArgumentNullException(nameof(isPositiveAnomaly));
            }

            Period = period;
            ExpectedValues = expectedValues.ToList();
            UpperMargins = upperMargins.ToList();
            LowerMargins = lowerMargins.ToList();
            IsAnomaly = isAnomaly.ToList();
            IsNegativeAnomaly = isNegativeAnomaly.ToList();
            IsPositiveAnomaly = isPositiveAnomaly.ToList();
            Severity = new ChangeTrackingList<float>();
        }

        /// <summary> Initializes a new instance of <see cref="UnivariateEntireDetectionResult"/>. </summary>
        /// <param name="period">
        /// Frequency extracted from the series, zero means no recurrent pattern has been
        /// found.
        /// </param>
        /// <param name="expectedValues">
        /// ExpectedValues contain expected value for each input point. The index of the
        /// array is consistent with the input series.
        /// </param>
        /// <param name="upperMargins">
        /// UpperMargins contain upper margin of each input point. UpperMargin is used to
        /// calculate upperBoundary, which equals to expectedValue + (100 -
        /// marginScale)*upperMargin. Anomalies in response can be filtered by
        /// upperBoundary and lowerBoundary. By adjusting marginScale value, less
        /// significant anomalies can be filtered in client side. The index of the array is
        /// consistent with the input series.
        /// </param>
        /// <param name="lowerMargins">
        /// LowerMargins contain lower margin of each input point. LowerMargin is used to
        /// calculate lowerBoundary, which equals to expectedValue - (100 -
        /// marginScale)*lowerMargin. Points between the boundary can be marked as normal
        /// ones in client side. The index of the array is consistent with the input
        /// series.
        /// </param>
        /// <param name="isAnomaly">
        /// IsAnomaly contains anomaly properties for each input point. True means an
        /// anomaly either negative or positive has been detected. The index of the array
        /// is consistent with the input series.
        /// </param>
        /// <param name="isNegativeAnomaly">
        /// IsNegativeAnomaly contains anomaly status in negative direction for each input
        /// point. True means a negative anomaly has been detected. A negative anomaly
        /// means the point is detected as an anomaly and its real value is smaller than
        /// the expected one. The index of the array is consistent with the input series.
        /// </param>
        /// <param name="isPositiveAnomaly">
        /// IsPositiveAnomaly contain anomaly status in positive direction for each input
        /// point. True means a positive anomaly has been detected. A positive anomaly
        /// means the point is detected as an anomaly and its real value is larger than the
        /// expected one. The index of the array is consistent with the input series.
        /// </param>
        /// <param name="severity">
        /// The severity score for each input point. The larger the value is, the more
        /// sever the anomaly is. For normal points, the "severity" is always 0.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnivariateEntireDetectionResult(int period, IReadOnlyList<float> expectedValues, IReadOnlyList<float> upperMargins, IReadOnlyList<float> lowerMargins, IReadOnlyList<bool> isAnomaly, IReadOnlyList<bool> isNegativeAnomaly, IReadOnlyList<bool> isPositiveAnomaly, IReadOnlyList<float> severity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Period = period;
            ExpectedValues = expectedValues;
            UpperMargins = upperMargins;
            LowerMargins = lowerMargins;
            IsAnomaly = isAnomaly;
            IsNegativeAnomaly = isNegativeAnomaly;
            IsPositiveAnomaly = isPositiveAnomaly;
            Severity = severity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UnivariateEntireDetectionResult"/> for deserialization. </summary>
        internal UnivariateEntireDetectionResult()
        {
        }

        /// <summary>
        /// Frequency extracted from the series, zero means no recurrent pattern has been
        /// found.
        /// </summary>
        public int Period { get; }
        /// <summary>
        /// ExpectedValues contain expected value for each input point. The index of the
        /// array is consistent with the input series.
        /// </summary>
        public IReadOnlyList<float> ExpectedValues { get; }
        /// <summary>
        /// UpperMargins contain upper margin of each input point. UpperMargin is used to
        /// calculate upperBoundary, which equals to expectedValue + (100 -
        /// marginScale)*upperMargin. Anomalies in response can be filtered by
        /// upperBoundary and lowerBoundary. By adjusting marginScale value, less
        /// significant anomalies can be filtered in client side. The index of the array is
        /// consistent with the input series.
        /// </summary>
        public IReadOnlyList<float> UpperMargins { get; }
        /// <summary>
        /// LowerMargins contain lower margin of each input point. LowerMargin is used to
        /// calculate lowerBoundary, which equals to expectedValue - (100 -
        /// marginScale)*lowerMargin. Points between the boundary can be marked as normal
        /// ones in client side. The index of the array is consistent with the input
        /// series.
        /// </summary>
        public IReadOnlyList<float> LowerMargins { get; }
        /// <summary>
        /// IsAnomaly contains anomaly properties for each input point. True means an
        /// anomaly either negative or positive has been detected. The index of the array
        /// is consistent with the input series.
        /// </summary>
        public IReadOnlyList<bool> IsAnomaly { get; }
        /// <summary>
        /// IsNegativeAnomaly contains anomaly status in negative direction for each input
        /// point. True means a negative anomaly has been detected. A negative anomaly
        /// means the point is detected as an anomaly and its real value is smaller than
        /// the expected one. The index of the array is consistent with the input series.
        /// </summary>
        public IReadOnlyList<bool> IsNegativeAnomaly { get; }
        /// <summary>
        /// IsPositiveAnomaly contain anomaly status in positive direction for each input
        /// point. True means a positive anomaly has been detected. A positive anomaly
        /// means the point is detected as an anomaly and its real value is larger than the
        /// expected one. The index of the array is consistent with the input series.
        /// </summary>
        public IReadOnlyList<bool> IsPositiveAnomaly { get; }
        /// <summary>
        /// The severity score for each input point. The larger the value is, the more
        /// sever the anomaly is. For normal points, the "severity" is always 0.
        /// </summary>
        public IReadOnlyList<float> Severity { get; }
    }
}
