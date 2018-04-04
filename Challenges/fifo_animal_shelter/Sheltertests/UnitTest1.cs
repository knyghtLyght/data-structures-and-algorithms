using System;
using Xunit;
using fifo_animal_shelter;

namespace Sheltertests
{
    public class UnitTest1
    {
        [Fact]
        public void implimentsAnimalC()
        {
            Assert.IsAssignableFrom<Animal>(new Cat());
        }

        [Fact]
        public void implimentsAnimalD()
        {
            Assert.IsAssignableFrom<Animal>(new Dog());
        }

        [Fact]
        public void CatNotNull()
        {
            Cat testCat = new Cat() { Name = "test" };

            Assert.NotNull(testCat.Name);
        }

        [Fact]
        public void CanBuildShelter()
        {
            Assert.NotNull(new AnimalShelter(new Cat() { Name = "kat" }, new Dog() { Name = "Apollo" }));
        }

        [Fact]
        public void CanEnqueueCat()
        {
            AnimalShelter testShelter = new AnimalShelter(new Cat() { Name = "kat" }, new Dog() { Name = "Apollo" });

            testShelter.Enqueue(new Node() { Value = new Cat() { Name = "fluffy" } });

            Assert.IsType<Cat>(testShelter.Peek("cat"));
        }

        [Fact]
        public void CanEnqueueDog()
        {
            AnimalShelter testShelter = new AnimalShelter(new Cat() { Name = "kat" }, new Dog() { Name = "Apollo" });

            testShelter.Enqueue(new Node() { Value = new Dog() { Name = "fido" } });

            Assert.IsType<Dog>(testShelter.Peek("dog"));
        }

        [Fact]
        public void CanDequeueCat()
        {
            AnimalShelter testShelter = new AnimalShelter(new Cat() { Name = "kat" }, new Dog() { Name = "Apollo" });

            testShelter.Enqueue(new Node() { Value = new Cat() { Name = "fluffy" } });

            Assert.IsType<Cat>(testShelter.Dequeue("cat"));
        }

        [Fact]
        public void CanDequeueDog()
        {
            AnimalShelter testShelter = new AnimalShelter(new Cat() { Name = "kat" }, new Dog() { Name = "Apollo" });

            testShelter.Enqueue(new Node() { Value = new Dog() { Name = "fido" } });

            Assert.IsType<Dog>(testShelter.Dequeue("dog"));
        }
    }
}
