using focus_aid.BusinessLogic;
using System.Runtime.CompilerServices;
using Moq;
using FakeItEasy;
using FluentAssertions;

namespace focus_aid.BusinessLogicTests
{
    public class CountdownSessionManagerUnitTests
    {
        
        [Test]
        public void Start_InitializesWithoutSeconds_ReturnsFalse()
        {
            // Arrange
            var csm = new CountdownManager();

            // Act
            bool result = csm.Start();

            // Assert
            result.Should().Be(false); 
        }

        [Test]
        public void Start_InitializesWithNegativeSeconds_ReturnsFalse()
        {
            // Arrange
            var csm = new CountdownSessionManager(-73);

            // Act
            bool result = csm.Start();

            // Assert
            result.Should().Be(false);
        }

        [Test]
        public void Start_InitializesWithZeroSeconds_ReturnsFalse()
        {
            // Arrange
            var csm = new CountdownSessionManager(0);

            // Act
            bool result = csm.Start();

            // Assert
            result.Should().Be(false);
        }

        [Test]
        public void Start_InitializesWithPositiveSeconds_ReturnsTrue()
        {
            // Arrange
            var csm = new CountdownSessionManager(3600);

            // Act
            bool result = csm.Start();

            // Assert
            result.Should().Be(true);
        }

    }
}