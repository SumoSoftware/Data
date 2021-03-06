﻿namespace Sumo.Data
{
    public class TestType
    {
        public string ReadWriteString { get; set; } = "ReadWriteProperty";
        public string ReadPrivateWriteString { get; private set; } = "ReadPrivateWriteString";
        public string ReadString { get; } = "ReadString";
        [IgnoreColumn]
        public string IgnoreString { get; set; } = "IgnoreString";
        public int ReadWriteInteger { get; set; } = 0;
    }

    public class ColumnAndParamAttributeTest
    {
        [ColumnName("property")]
        [InputOutputParameter(64)]
        public string MyProperty { get; set; }
    }

    [EntityPrefix("prefix")]
    public class TestTypeParameterSize
    {
        [OutputParameter(nameof(StringOutputParameter), 256)]
        public string StringOutputParameter { get; set; } = "StringOutputParameter";

        [OutputParameter]
        public int IntOutputParameter { get; set; } = 1;

        [InputParameter]
        public int InputParameter { get; set; } = 1;
    }

    [EntityPrefix("prefix")]
    [EntityName("test_name")]
    public class TestTypePrefixAndCustomNameIgnoreColumn
    {
        public string ReadWriteProperty { get; set; } = "ReadWriteProperty";
        public string ReadPrivateWriteProperty { get; private set; } = "ReadPrivateWriteProperty";
        public string ReadProperty { get; } = "ReadProperty";

        [IgnoreColumn]
        public string IgnoreProperty { get; set; } = "IgnoreProperty";

        [OutputParameter]
        public int OutputParameter { get; set; } = 1;
    }

    [EntityPrefix("prefix")]
    [EntityName("test_name")]
    public class TestTypePrefixAndCustomNameIgnoreParameter
    {
        public string ReadWriteProperty { get; set; } = "ReadWriteProperty";
        public string ReadPrivateWriteProperty { get; private set; } = "ReadPrivateWriteProperty";
        public string ReadProperty { get; } = "ReadProperty";

        [IgnoreParameter]
        public string IgnoreProperty { get; set; } = "IgnoreProperty";

        [OutputParameter]
        public int OutputParameter { get; set; } = 1;
    }

    [EntityPrefix("prefix")]
    public class TestTypePrefix
    {
        public string ReadWriteProperty { get; set; } = "ReadWriteProperty";
        public string ReadPrivateWriteProperty { get; private set; } = "ReadPrivateWriteProperty";
        public string ReadProperty { get; } = "ReadProperty";
        [IgnoreColumn]
        public string IgnoreProperty { get; set; } = "IgnoreProperty";
        [OutputParameter]
        public string OutputParameter { get; set; } = "OutputParameter";
    }

    public class TestTypeReadOnlyProperties
    {
        private string _writeOnlyProperty;
        public string SetOnlyProperty { set { _writeOnlyProperty = value; } }
        public string PrivateSetProperty { get; private set; } = "ReadPrivateWriteProperty";
        public string GetOnlyProperty { get; } = "ReadProperty";

        [IgnoreColumn]
        public string IgnoredProperty { get; set; } = "IgnoredProperty";

        public int GetSetProperty { get; set; } = 1;
    }

    public class TestTypeInputOutputParams
    {
        public string InputParameter { get; set; } = "InputParameter";
        [IgnoreColumn]
        public string IgnoreProperty { get; set; } = "IgnoreProperty";
        [OutputParameter]
        public string OutputParameter { get; set; } = "OutputParameter";
        [InputOutputParameter]
        public string InputOutputParameter { get; set; } = "InputOutputParameter";
    }
}
