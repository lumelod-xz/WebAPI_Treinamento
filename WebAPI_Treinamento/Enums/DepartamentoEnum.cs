﻿using System.Text.Json.Serialization;

namespace WebAPI_Treinamento.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        RH,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria
    }
}
