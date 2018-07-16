using Xunit;

namespace BasicCSharp
{
    public class AnnonymousTypes
    {
        [Fact]
        public void should_define_data_type_without_class_definition()
        {
            var annonymousTypeInstance = new
            {
                FirstName = "Bill",
                LastName = "Gates"
            };

            // please update the variable values for the following 2 lines to fix the test.
            const string expectedFirstName = "Bill";
            const string expectedLastName = "Gates";

            Assert.Equal(expectedFirstName, annonymousTypeInstance.FirstName);
            Assert.Equal(expectedLastName, annonymousTypeInstance.LastName);
        }

        [Fact]
        public void should_resolve_property_name_by_variable_name()
        {
            const string firstName = "Bill";

            var annonymousTypeInstance = new
            {
                firstName,
                LastName = "Gates"
            };

            // please update the variable values for the following 2 lines to fix the test.
            const string expectedFirstName = "Bill";
            const string expectedLastName = "Gates";

            Assert.Equal(expectedFirstName, annonymousTypeInstance.firstName);
            Assert.Equal(expectedLastName, annonymousTypeInstance.LastName);
        }

        [Fact]
        public void should_create_nested_anonymous_type()
        {
            var personalInformation = new
            {
                Name = new
                {
                    FirstName = "Bill",
                    LastName = "Gates"
                },
                Age = 59
            };

            // please update the variable values for the following 3 lines to fix the test.
            const string expectedFirstName = "Bill";
            const string expectedLastName = "Gates";
            const int expectedAge = 59;

            Assert.Equal(expectedFirstName, personalInformation.Name.FirstName);
            Assert.Equal(expectedLastName, personalInformation.Name.LastName);
            Assert.Equal(expectedAge, personalInformation.Age);
        }
    }
}