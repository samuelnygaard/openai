﻿using System.Text.Json.Serialization;

namespace OpenAI.GPT3.Models.ResponseModels
{
    public record SearchCreateResponse : BaseResponse
    {
        [JsonPropertyName("data")] public SearchResult[] Data { get; set; }
    }

    public record SearchResult : BaseResponse
    {
        [JsonPropertyName("document")] public int Document { get; set; }

        [JsonPropertyName("score")] public float Score { get; set; }
    }
}