using focus_aid.BusinessLogic;
using System.Runtime.CompilerServices;
using Moq;
using FakeItEasy;
using FluentAssertions;

namespace focus_aid.BusinessLogicTests
{
    public class CountdownSessionManagerUnitTests
    {
        public int InitializedSeconds = 3600;
        
        [Test]
        public void Start_InitializesSecondsPropertiesAndDelegatesToUI_ReturnsTrue()
        {
            // Arrange
            var csm = A.Fake<CountdownSessionManager>();

            // Act

            bool result = csm.Start();


            // Assert
   
            result.Should().Be(true);
            A.CallTo(() => csm.DelegateCountdownToUI()).MustHaveHappened(); //can't intercept ? why? interface? 

        }
    }
}