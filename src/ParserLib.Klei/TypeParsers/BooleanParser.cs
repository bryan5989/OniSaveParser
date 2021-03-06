﻿using System.Collections.Generic;

namespace SheepReaper.GameSaves.Klei.TypeParsers
{
    public class BooleanParser : IParser<bool>
    {
        public bool Parse(IDataReader reader, TypeInfo info, List<Template> templates) => reader.ReadBoolean();

        object IParser.Parse(IDataReader reader, TypeInfo info, List<Template> templates) => Parse(reader, info, templates);
    }
}