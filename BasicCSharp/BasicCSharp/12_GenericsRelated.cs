using System;
using BasicCSharp.Common;
using BasicCSharp.Extensions;
using Xunit;

namespace BasicCSharp
{
    public class GenericsRelated
    {
        [Fact]
        public void should_resolve_correct_type()
        {
            var genericObjectWithStringAsTypeArgument = new BasicGenericDemoClass<string>();

            Type valuePropertyType = genericObjectWithStringAsTypeArgument.GetPropertyType("Value");

            // correct the variable value to fix the test
            Type expectedValuePropertyType = typeof(object);

            Assert.Equal(expectedValuePropertyType, valuePropertyType);
        }

        [Fact]
        public void should_restrict_to_value_type_on_type_argument()
        {
            var demoObject = new ValueTypeRestrictedGenericDemoClass<int>();

            // correct the variable value to fix the test
            const int expectedInitialValue = 1;

            Assert.Equal(expectedInitialValue, demoObject.Value);
        }

        [Fact]
        public void should_restrict_to_ref_type_on_type_argument()
        {
            var demoObject = new RefTypeRestrictedGenericDemoClass<string>();

            // correct the variable value to fix the test
            const string expectedInitialValue = "Hello";

            Assert.Equal(expectedInitialValue, demoObject.Value);
        }

        [Fact]
        public void should_restrict_to_default_constructor_on_type_argument()
        {
            var demoObject = new DefaultCtorRestrictedGenericDemoClass<SayHelloByDefault>();

            // correct the variable value to fix the test
            const string expectedStringValue = default(string);

            Assert.Equal(expectedStringValue, demoObject.Value.ToString());
        }

        [Fact]
        public void should_restrict_to_interface_on_type_argument()
        {
            var demoObject = new InterfaceRestrictedGenericDemoClass<Duck>();

            // correct the variable value to fix the test
            const string expectedStringValue = "";

            Assert.Equal(expectedStringValue, demoObject.ToString());
        }

        [Fact]
        public void should_automatically_resolve_parameter_type()
        {
            string actualReturnValue = GenericMethodDemoClass.ResolvableGenericMethod(new Duck());

            // correct the variable value to fix the test
            const string expectedReturnValue = "";

            Assert.Equal(expectedReturnValue, actualReturnValue);
        }

        [Fact]
        public void should_specify_type_if_type_argument_cannot_be_resovled()
        {
            string actualReturnValue = GenericMethodDemoClass.NotResolvableGenericMethod<string>();

            // correct the variable value to fix the test
            const string expectedReturnValue = "";

            Assert.Equal(expectedReturnValue, actualReturnValue);
        }

        [Fact]
        public void should_be_different_types_for_different_type_argument()
        {
            // correct the variable value to fix the test
            const bool areEqual = true;

            Assert.Equal(
                areEqual,
                typeof(BasicGenericDemoClass<int>) == typeof(BasicGenericDemoClass<string>));
        }

        [Fact]
        public void should_be_unique_for_different_closed_type()
        {
            GenericTypeStaticDataDemoClass<int>.Count++;
            GenericTypeStaticDataDemoClass<string>.Count = 5;
            GenericTypeStaticDataDemoClass<int>.Count = 2;

            // correct the variable values for the following 2 lines to fix the test
            const int expectedCountForIntClosedType = 0;
            const int expectedCountForStringClosedType = 0;

            Assert.Equal(expectedCountForIntClosedType, GenericTypeStaticDataDemoClass<int>.Count);
            Assert.Equal(expectedCountForStringClosedType, GenericTypeStaticDataDemoClass<string>.Count);
        }

        [Fact]
        public void should_declare_out_if_generic_type_is_covariant()
        {
            var covariantDemoObject = new CovariantContravariantDemoClass<string>("Hello");
            ICovariantGetDemo<object> covariantWithBaseTypeArgument = covariantDemoObject;
            object value = covariantWithBaseTypeArgument.Get();

            // correct the variable value to fix the test
            object expectedValue = null;

            Assert.Equal(expectedValue, value);
        }

        [Fact]
        public void should_declare_in_if_generic_type_is_contravariant()
        {
            var contravariantDemoObject = new CovariantContravariantDemoClass<object>(null);
            IContravariantSetDemo<string> contravariantWithDerivedTypeArgument =
                contravariantDemoObject;
            contravariantWithDerivedTypeArgument.Put("Hello");

            // correct the variable value to fix the test
            object expectedValue = null;

            Assert.Equal(expectedValue, contravariantDemoObject.Get());
        }
    }
}