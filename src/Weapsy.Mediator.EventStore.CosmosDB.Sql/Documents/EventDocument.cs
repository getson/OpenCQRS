﻿using System;
using Newtonsoft.Json;

namespace Weapsy.Mediator.EventStore.CosmosDB.Sql.Documents
{
    public class EventDocument
    {
        [JsonProperty(PropertyName = "aggregateId")]
        public Guid AggregateId { get; set; }

        [JsonProperty(PropertyName = "sequence")]
        public int Sequence { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        [JsonProperty(PropertyName = "timeStamp")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public Guid UserId { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
    }
}