﻿namespace Ticketing.Application.Contracts.FormSchemaField.Commands;

public class NewFormSchemaFieldCommand
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int FormSchemaId { get; set; }
}