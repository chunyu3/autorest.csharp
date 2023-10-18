// <auto-generated/>

#nullable disable

using System.Net.ClientModel.Core;
using System.Net.ClientModel.Internal;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class FineTuneHyperparams
    {
        internal static FineTuneHyperparams DeserializeFineTuneHyperparams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long nEpochs = default;
            long batchSize = default;
            double promptLossWeight = default;
            double learningRateMultiplier = default;
            OptionalProperty<bool> computeClassificationMetrics = default;
            OptionalProperty<string> classificationPositiveClass = default;
            OptionalProperty<long> classificationNClasses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("n_epochs"u8))
                {
                    nEpochs = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("batch_size"u8))
                {
                    batchSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("prompt_loss_weight"u8))
                {
                    promptLossWeight = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("learning_rate_multiplier"u8))
                {
                    learningRateMultiplier = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("compute_classification_metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeClassificationMetrics = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("classification_positive_class"u8))
                {
                    classificationPositiveClass = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classification_n_classes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    classificationNClasses = property.Value.GetInt64();
                    continue;
                }
            }
            return new FineTuneHyperparams(nEpochs, batchSize, promptLossWeight, learningRateMultiplier, OptionalProperty.ToNullable(computeClassificationMetrics), classificationPositiveClass.Value, OptionalProperty.ToNullable(classificationNClasses));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="result"> The result to deserialize the model from. </param>
        internal static FineTuneHyperparams FromResponse(PipelineResponse result)
        {
            using var document = JsonDocument.Parse(result.Content);
            return DeserializeFineTuneHyperparams(document.RootElement);
        }
    }
}
