using System;
using NUnit.Framework;
using Sample.Integration.Events;

namespace Tests {
    public class NameChangedTests {
        [Test]
        public void NullNameThrowsArgumentException() {
            // Arrange & Act & Assert
            Assert.That(() => new NameChanged(Guid.NewGuid(), null), Throws.ArgumentException);
        }

        [Test]
        public void NotNullNameDoesNotThrowArgumentException() {
            // Arrange 
            var id = Guid.NewGuid();
            var name = "Any Name";

            // Act
            var sut = new NameChanged(id, name);
            var sutName = sut.Name;

            // Assert
            Assert.AreEqual(id, sut.EventId);
            Assert.AreEqual(name,sut.Name);
        }
    }
}