using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BasicCSharp.Common;
using Xunit;
/**
 * object所有对象的父类
 */
namespace BasicCSharp
{
    public class ObjectTypes
    {
        [Fact]
        public void all_types_are_derived_from_object()
        {
            var stringInstance = "a string";
            var annonymousInstance = new { };
            var valueTypeInstance = 2;

            // change the variable values for the following 3 lines to fix the test.
            const bool isStringInstanceObject = true;
            const bool isAnnonymousInstanceObject = true;
            const bool isValueTypeInstanceObject = true;

            Assert.Equal(
                isStringInstanceObject,
                stringInstance.GetType().IsSubclassOf(typeof(object)));
            Assert.Equal(
                isAnnonymousInstanceObject,
                annonymousInstance.GetType().IsSubclassOf(typeof(object)));
            Assert.Equal(
                isValueTypeInstanceObject,
                valueTypeInstance.GetType().IsSubclassOf(typeof(object)));
        }

        [Fact]
        public void should_cast_to_object_for_any_instance()
        {
            var objectList = new List<object> {"String", 2, new RefTypeClass(2)};

            object itemAtPosition0 = objectList[0];
            object itemAtPosition1 = objectList[1];
            object itemAtPosition2 = objectList[2];

            // change the variable values for the following 3 lines to fix the test.
            Type expectedTypeForItemAtPosition0 = typeof(string);
            Type expectedTypeForItemAtPosition1 = typeof(int);
            Type expectedTypeForItemAtPosition2 = typeof(RefTypeClass);

            Assert.Equal(expectedTypeForItemAtPosition0, itemAtPosition0.GetType());
            Assert.Equal(expectedTypeForItemAtPosition1, itemAtPosition1.GetType());
            Assert.Equal(expectedTypeForItemAtPosition2, itemAtPosition2.GetType());
        }
        /**
         * valueType:Provides the base class for value types.
         */
        [Fact]
        public void should_derived_from_value_type_for_value_type()
        {
            int intObject = 1;
            DateTime dateTimeObject = DateTime.Now;
            var customValueTypeObject = new ValueTypeDemoClass();

            // change the variable values for the following 3 lines to fix the test.
            const bool isIntObjectValueType = true;
            const bool isDateTimeObjectValueType = true;
            const bool isCustomValueTypeObjectValueType = true;

            Assert.Equal(
                isIntObjectValueType, 
                intObject.GetType().IsSubclassOf(typeof(ValueType)));
            Assert.Equal(
                isDateTimeObjectValueType,
                dateTimeObject.GetType().IsSubclassOf(typeof(ValueType)));
            Assert.Equal(
                isCustomValueTypeObjectValueType,
                customValueTypeObject.GetType().IsSubclassOf(typeof(ValueType)));
        }
        /**
         * sealed??
         */
        [Fact]
        public void should_be_sealed_for_value_type()
        {
            var customValueTypeObject = new ValueTypeDemoClass();

            // change the variable value to fix the test.
            const bool isValueTypeSealed = true;

            Assert.Equal(isValueTypeSealed, customValueTypeObject.GetType().IsSealed);
        }

        [Fact]
        public void should_perform_real_copy_operation_for_value_type()
        {
            var original = new ValueTypeDemoClass();

            ValueTypeDemoClass copy = original;
            bool isSameReference;

            unsafe
            {
                ValueTypeDemoClass* originalPtr = &original;
                ValueTypeDemoClass* copyPtr = &copy;

                isSameReference = originalPtr == copyPtr;
            }

            // change the variable value to fix the test.
            const bool expectedIsSameReference = false;

            Assert.Equal(expectedIsSameReference, isSameReference);
        }

        [Fact]
        public void should_as_if_nothing_different_occurrs_when_doing_boxing_operation()
        {
            int intObject = 1;
            var boxed = (object) intObject;

            // change the variable values for the following 3 lines to fix the test.
            Type expectedType = typeof(int);
            const bool isBoxedTypeSealed = true;
            const bool isValueType = true;

            Assert.Equal(expectedType, boxed.GetType());
            Assert.Equal(isBoxedTypeSealed, boxed.GetType().IsSealed);
            Assert.Equal(isValueType, boxed.GetType().IsValueType);
        }

        [Fact]
        public void should_make_explicity_cast_when_doing_unboxing_operation()
        {
            int intObject = 1;
            var boxed = (object) intObject;
            long longObject = 0;
            Exception errorWhenCasting = null;

            try
            {
                longObject = (long) boxed;
            }
            catch (Exception error)
            {
                errorWhenCasting = error;
            }

            // change the variable values for the following 3 lines to fix the test.
            const bool isExceptionOccurred = true;
            Type expectedExceptionType = typeof(InvalidCastException);
            const long expectedLongObjectValue = 0;

            Assert.Equal(isExceptionOccurred, (errorWhenCasting != null));
            Assert.Equal(expectedExceptionType, errorWhenCasting.GetType());
            Assert.Equal(expectedLongObjectValue, longObject);
        }

        [Fact]
        public void should_get_most_derived_type_when_call_get_type_method()
        {
            var derivedClassObject = new InheritMemberAccessDemoClass();
            var castedToBaseClass = (InheritMemberAccessDemoBaseClass)derivedClassObject;

            Type type = castedToBaseClass.GetType();

            // change the variable value to fix the test.
            Type expectedType = typeof(InheritMemberAccessDemoClass);

            Assert.Equal(expectedType, type);
        }
        /**
         * if subclass no method; use baseclass;
         */
        [Fact]
        public void should_print_object_type_if_no_override_is_available_for_to_string_method()
        {
            var objectWithoutToStringOverride = new RefTypeClass(2);
            
            // change the variable value to fix the test.
            const string expectedToStringResult = "BasicCSharp.Common.RefTypeClass";

            string toStringResult = objectWithoutToStringOverride.ToString();

            Assert.Equal(expectedToStringResult, toStringResult);
        }
    }
}