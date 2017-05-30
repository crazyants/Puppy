﻿namespace Puppy.Search.Elastic.Model.SearchModel.Aggregations
{
    /// <summary>
    ///     A multi-value metrics aggregation that computes stats over numeric values extracted from
    ///     the aggregated documents. These values can be extracted either from specific numeric
    ///     fields in the documents, or be generated by a provided script. The stats that are
    ///     returned consist of: min, max, sum, count and avg.
    /// </summary>
    public class StatsMetricAggregation : BaseMetricAggregation
    {
        public StatsMetricAggregation(string name, string field) : base("stats", name, field)
        {
        }

        public override void WriteJson(ElasticJsonWriter elasticCrudJsonWriter)
        {
            WriteJsonBase(elasticCrudJsonWriter, WriteValues);
        }

        private void WriteValues(ElasticJsonWriter elasticCrudJsonWriter)
        {
        }
    }
}