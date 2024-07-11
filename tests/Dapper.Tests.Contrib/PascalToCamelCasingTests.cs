using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper.Contrib.Extensions;
using Xunit;

using FactAttribute = Dapper.Tests.Contrib.SkippableFactAttribute;

namespace Dapper.Tests.Contrib
{
    public class PascalToCamelCasingTests
    {
        [Fact]
        public void ConvertToCamelCase()
        {
            Assert.Equal("Full_Name", ColumnMapping.PascalCaseToSnakeCase("FullName"));
            Assert.Equal("The_Id", ColumnMapping.PascalCaseToSnakeCase("TheId"));
            Assert.Equal("I_D", ColumnMapping.PascalCaseToSnakeCase("ID"));
        }
    }
}
