namespace _01.Loader.Tests
{
    using _01.Loader.Interfaces;
    using _01.Loader.Models;
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Reflection;

    public class LoaderTests
    {
        private IBuffer _buffer;
        private IEntity _savedEntity;
        private int[] _statusesCount;

        [SetUp]
        public void Setup()
        {
            this._buffer = new Loader();
            ConstructorInfo[] constructors = {
                this.GetConstructorInfo(typeof(Invoice)) ,
                this.GetConstructorInfo(typeof(StoreClient)),
                this.GetConstructorInfo(typeof(User))
            };
            Random rnd = new Random();
            int boundIndex = rnd.Next(25);
            BaseEntityStatus[] statuses = (BaseEntityStatus[])
                Enum.GetValues(typeof(BaseEntityStatus));
            this._statusesCount = new int[statuses.Length];

            for (int i = 0; i < 25; i++)
            {
                var rndConstructor = constructors[rnd.Next(constructors.Length)];
                IEntity entity = (IEntity)rndConstructor.Invoke(new object[] { i, i + 13 });
                if (i == boundIndex)
                {
                    this._savedEntity = entity;
                }
                int rndEnumIndex = rnd.Next(statuses.Length);
                entity.Status = statuses[rndEnumIndex];
                this._statusesCount[rndEnumIndex]++;
                this._buffer.Add(entity);
            }
        }

        private ConstructorInfo GetConstructorInfo(Type eType)
        {
            return eType.GetConstructor(new Type[] { typeof(int), typeof(int) });
        }

        [Test]
        public void AddWorksCorrectly()
        {
            Assert.AreEqual(25, this._buffer.EntitiesCount);
        }

        [Test]
        public void ExtractWorksCorrectly()
        {
            var entity = this._buffer.Extract(1);
            Assert.IsNotNull(entity);
            Assert.AreEqual(1, entity.Id);
            Assert.AreEqual(24, this._buffer.EntitiesCount);
        }

        [Test]
        public void FindWorksCorrectly()
        {
            var entity = this._buffer.Find(this._savedEntity);
            Assert.IsNotNull(entity);
            Assert.AreEqual(this._savedEntity.Id, entity.Id);
        }

        [Test]
        public void ContainsWorksCorrectly()
        {
            Assert.IsTrue(this._buffer.Contains(this._savedEntity));
        }


        [Test]
        public void EntitiesCountWorksCorrectly()
        {
            Assert.AreEqual(0, new Loader().EntitiesCount);
            Assert.AreEqual(25, this._buffer.EntitiesCount);
            this._buffer.Extract(1);
            this._buffer.Extract(2);
            this._buffer.Extract(3);
            Assert.AreEqual(22, this._buffer.EntitiesCount);
        }

        [Test]
        public void ReplaceWorksCorrectly()
        {
            this._buffer.Replace(this._savedEntity, new Invoice(1000, 999));
            IEntity entity = this._buffer.Extract(1000);
            Assert.IsNotNull(entity);
        }

        [Test]
        public void SwapWorksCorrectly()
        {
            var firstEntity = new User(26, 23);
            var secondEntity = new Invoice(27, 24);
            this._buffer.Add(firstEntity);
            this._buffer.Add(secondEntity);

            int indexOfFirst = this._buffer.EntitiesCount - 2;
            int indexOfSecond = this._buffer.EntitiesCount - 1;

            this._buffer.Swap(firstEntity, secondEntity);
            var allEntities = this._buffer.GetAll();

            Assert.NotNull(allEntities[indexOfFirst]);
            Assert.NotNull(allEntities[indexOfSecond]);
            Assert.AreEqual(allEntities[indexOfFirst].Id, secondEntity.Id);
            Assert.AreEqual(allEntities[indexOfSecond].Id, firstEntity.Id);
        }

        [Test]
        public void ClearWorksCorrectly()
        {
            Assert.AreEqual(25, this._buffer.EntitiesCount);
            this._buffer.Clear();
            Assert.AreEqual(0, this._buffer.EntitiesCount);
        }


        [Test]
        public void ToArrayWorksCorrectly()
        {
            IEntity[] entities = this._buffer.ToArray();
            Assert.AreEqual(25, entities.Length);
        }

        [Test]
        public void RatainAllWorksCorrectly()
        {
            int totalCount = this._statusesCount[(int)BaseEntityStatus.Reserved]
                + this._statusesCount[(int)BaseEntityStatus.PendingFunds]
                + this._statusesCount[(int)BaseEntityStatus.Payed];

            var entities = this._buffer.RetainAllFromTo(BaseEntityStatus.Reserved, BaseEntityStatus.Payed);
            Assert.AreEqual(totalCount, entities.Count);
            Assert.IsFalse(entities.Any(e => e.Status.Equals(BaseEntityStatus.InStore)));
            Assert.IsFalse(entities.Any(e => e.Status.Equals(BaseEntityStatus.Sold)));
        }

        [Test]
        public void GetAllWorksCorrectly()
        {
            var allEntities = this._buffer.GetAll();
            Assert.AreEqual(25, allEntities.Count);
        }

        [Test]
        public void UpdateAllWorksCorrectly()
        {
            Func<IEntity, bool> checkContainingStatus = (e) => e.Status.Equals(BaseEntityStatus.InStore);
            var incoice = new Invoice(23, 23);
            incoice.Status = BaseEntityStatus.InStore;

            this._buffer.Add(incoice);
            Assert.IsTrue(this._buffer.GetAll().Any(checkContainingStatus));
            this._buffer.UpdateAll(BaseEntityStatus.InStore, BaseEntityStatus.Payed);
            var entities = this._buffer.GetAll();

            Assert.AreEqual(26, entities.Count);
            Assert.IsFalse(entities.Any(checkContainingStatus));
        }

        [Test]
        public void RemoveSoldWorksCorrectly()
        {
            var entity = new User(26, 23);
            entity.Status = BaseEntityStatus.Sold;
            this._buffer.Add(entity);

            this._buffer.RemoveSold();

            var allWithStatusSold = this._buffer
                .GetAll()
                .Where(e => e.Status.Equals(BaseEntityStatus.Sold));
            Assert.IsEmpty(allWithStatusSold);
        }

        [Test]
        public void EnumerationWorksCorrectly()
        {
            int count = 0;
            Assert.AreEqual(25, this._buffer.EntitiesCount);
            foreach (var entity in this._buffer)
            {
                count++;
            }

            Assert.AreEqual(count, this._buffer.EntitiesCount);
        }
    }
}