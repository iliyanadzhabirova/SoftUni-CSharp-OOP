namespace Tests
{
    using NUnit.Framework;
    using Database;

    [TestFixture]
    public class DatabaseTests
    {
        private const int DatabaseCapacity = 16;
        private Database database;

        [SetUp]
        public void Setup()
        {
            this.database = new Database();
        }

        [Test]
        [TestCase(10)]
        [TestCase(10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 1, 2, 3, 4, 5, 6)]
        public void ConstructorShouldInitializeDatabaseElementsCorrectly(params int[] numbers)
        {
            this.database = new Database(numbers);

            int[] dbElements = this.database.Fetch();

            for (int i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(dbElements[i], numbers[i]);
            }
        }

        [Test]
        public void ConstructorShouldInitializeDatabaseWithExactly16Elements()
        {
            int[] array = new int[16];
            this.database = new Database(array);

            Assert.AreEqual(DatabaseCapacity, database.Count, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void AddOperationShouldAddElementInTheNextFreeCell()
        {
            this.database.Add(255);
            Assert.AreEqual(1, database.Count, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        [TestCase(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)]
        public void AddOperationExceeding16ElementsShouldThrowInvalidOperationException(params int[] arr)
        {
            this.database = new Database(arr);
            Assert.That(() => this.database.Add(17), Throws.InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void FetchOperationShouldReturnTheElementsAsArray()
        {
            int[] arr = this.database.Fetch();
            Assert.That(arr, Is.TypeOf<int[]>());
        }

        [Test]
        public void RemoveOperationShouldRemoveElementAtLastIndex()
        {
            this.database = new Database(5);
            this.database.Remove();
            Assert.AreEqual(0, this.database.Count, "The collection is empty!");
        }

        [Test]
        public void RemoveOperationOnEmptyCollectionShouldThrowInvalidOperationException()
        {
            Assert.That(() => this.database.Remove(), Throws.InvalidOperationException.With.Message.EqualTo("The collection is empty!"));
        }
    }
}
