namespace _02.Data.Tests
{
    using NUnit.Framework;
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using _02.Data.Interfaces;
    using System.Linq;
    using _02.Data.Models;

    public class DataTests
    {
        private IRepository _data;
        private int _parentId;
        private IEntity _savedEntity;
        private int[] _statusesCount;

        [SetUp]
        public void Setup()
        {
            this._data = new Data();
            ConstructorInfo[] constructors = {
                this.GetConstructorInfo(typeof(Invoice)) ,
                this.GetConstructorInfo(typeof(StoreClient)),
                this.GetConstructorInfo(typeof(User))
            };
            Random rnd = new Random();
            BaseEntityStatus[] statuses = (BaseEntityStatus[])
                Enum.GetValues(typeof(BaseEntityStatus));
            this._statusesCount = new int[statuses.Length];
            List<int> parentIds = new List<int>();
            parentIds.Add(0);
            for (int i = 0; i < 25; i++)
            {
                var rndConstructor = constructors[rnd.Next(constructors.Length)];
                int nextInt = rnd.Next(i + 1);
                IEntity entity = (IEntity)rndConstructor.Invoke(new object[] { i, parentIds[nextInt] });
                parentIds.Add(i);
                if (entity.Id == 13)
                {
                    this._parentId = (int)entity.ParentId;
                    this._savedEntity = entity;
                }
                int rndEnumIndex = rnd.Next(statuses.Length);
                entity.Status = statuses[rndEnumIndex];
                this._statusesCount[rndEnumIndex]++;
                this._data.Add(entity);
            }
        }

        [Test]
        public void TestSizeWorksCorrectly()
        {
            Assert.AreEqual(25, this._data.Size);
        }

        [Test]
        public void TestAddWorksCorrectly()
        {
            var entity = new Invoice(25, 24);
            this._data.Add(entity);
            Assert.AreEqual(26, this._data.Size);
        }

        [Test]
        public void TestGetByIdWorksCorrectly()
        {
            var entity = this._data.GetById(13);
            Assert.AreEqual(13, entity.Id);
            Assert.AreEqual(this._parentId, entity.ParentId);
        }

        [Test]
        public void TestGetByParentIdWorksCorrectly()
        {
            var byParentId = this._data.GetByParentId(this._parentId);
            Assert.IsTrue(byParentId.Any(e => e.Id == 13));
            Assert.IsTrue(byParentId.All(e => e.ParentId == this._parentId));
        }

        [Test]
        public void TestGetAllWorksCorrectly()
        {
            var entities = this._data.GetAll()
                .OrderBy(e => e.Id)
                .ToList();

            for (int i = 0; i < entities.Count; i++)
            {
                Assert.AreEqual(i, entities[i].Id);
            }
        }

        [Test]
        public void TestCopyWorksCorrectly()
        {
            var copy = this._data.Copy();
            var dataAll = this._data.GetAll();
            var copyAll = copy.GetAll();
            Assert.AreNotSame(dataAll, copyAll);

            dataAll = dataAll
                .OrderBy(e => e.Id)
                .ToList();
            copyAll = copyAll
               .OrderBy(e => e.Id)
               .ToList();
            Assert.AreEqual(dataAll.Count, copyAll.Count);
            for (int i = 0; i < dataAll.Count; i++)
            {
                Assert.AreEqual(dataAll[i].Id, copyAll[i].Id);
            }
        }

        [Test]
        public void TestGetAllByTypeWorksCorrectly()
        {
            this._data.Add(new Invoice(26, 23));
            string searchedType = typeof(Invoice).Name;
            var expectedEntities = this._data.GetAll()
                .Where(e => e.GetType().Name.Equals(searchedType))
                .ToList();
            var actualEntities = this._data.GetAllByType(searchedType);

            Assert.AreEqual(expectedEntities.Count, actualEntities.Count);

            foreach (var entity in actualEntities)
            {
                Assert.AreEqual(searchedType, entity.GetType().Name);
            }
        }

        [Test]
        public void TestPeekMostRecentWorksCorrectly()
        {
            var entity = this._data.PeekMostRecent();
            Assert.AreEqual(25, this._data.Size);
            Assert.AreEqual(24, entity.Id);
        }

        [Test]
        public void TestDequeueMostRecentWorksCorrectly()
        {
            var entity = this._data.DequeueMostRecent();
            Assert.AreEqual(24, this._data.Size);
            Assert.AreEqual(24, entity.Id);
            Assert.AreEqual(23, this._data.PeekMostRecent().Id);
        }


        [Test]
        public void TestDequeueMostRecentMultipleTimesWorksCorrectly()
        {
            for (int i = 0; i < 10; i++)
            {
                this._data.DequeueMostRecent();
            }

            Assert.AreEqual(15, this._data.Size);
        }

        private ConstructorInfo GetConstructorInfo(Type eType)
        {
            return eType.GetConstructor(new Type[] { typeof(int), typeof(int) });
        }
    }
}