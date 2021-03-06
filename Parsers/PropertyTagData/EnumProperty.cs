﻿using PakReader.Parsers.Objects;

namespace PakReader.Parsers.PropertyTagData
{
    public sealed class EnumProperty : BaseProperty<FName>
    {
        internal EnumProperty(PackageReader reader, FPropertyTag tag)
        {
            Value = reader.ReadFName();
        }
    }
}
