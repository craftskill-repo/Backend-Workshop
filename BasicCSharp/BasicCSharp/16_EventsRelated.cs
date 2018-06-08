using System;
using BasicCSharp.Common;
using Xunit;

namespace BasicCSharp
{
    public class EventsRelated
    {
        [Fact]
        public void event_is_subset_of_delegate_with_event_handler_type()
        {
            var demoObject = new BasicEventDemoClass();
            var eventIsCalled = false;

            EventHandler eventHandler = (sender, eventArgs) =>
            {
                eventIsCalled = true;
            };

            demoObject.Event += eventHandler;

            demoObject.TriggerEvent();

            // change the variable value to fix the test.
            const bool expectedIsEventCalled = false;

            Assert.Equal(expectedIsEventCalled, eventIsCalled);
        }

        [Fact]
        public void should_unbind_event()
        {
            var demoObject = new BasicEventDemoClass();
            var eventIsCalled = false;

            EventHandler eventHandler = (sender, eventArgs) =>
            {
                eventIsCalled = true;
            };

            demoObject.Event += eventHandler;
            demoObject.Event -= eventHandler;

            demoObject.TriggerEvent();

            // change the variable value to fix the test.
            const bool expectedIsEventCalled = true;

            Assert.Equal(expectedIsEventCalled, eventIsCalled);
        }

        [Fact]
        public void should_be_able_to_customize_event_args()
        {
            var demoObject = new CustomizeEventArgsDemoClass();
            string greetingContent = string.Empty;

            EventHandler<GreetingEventArgs> eventHandler = (sender, eventArgs) =>
            {
                greetingContent = eventArgs.GreetingContent;
            };

            demoObject.Greeting += eventHandler;

            demoObject.Greet("World");

            // change the variable value to fix the test.
            const string expectedContent = "";

            Assert.Equal(expectedContent, greetingContent);
        }

        [Fact]
        public void should_customize_event_accessor()
        {
            var demoObject = new CustomizeEventAccessorDemoClass();

            // change the variable value to fix the test.
            var expectedExceptionType = typeof(Exception);

            Assert.Throws(expectedExceptionType, () => demoObject.Event += null);
        }
    }
}