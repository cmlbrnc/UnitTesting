using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Test
{
    [TestClass]
    public class GroupByTests
    {
        private List<Measurement> creatMeasurementList(int number)
        {
            var measurements = new List<Measurement>();
            for (int i = 0; i < number; i++)
            {

                {
                    new Measurement()
                    {
                        highest = 20,
                        lowest = 11
                    };
                };
            }

            return measurements;

        }
        [TestMethod]
        public void group_by_number_1()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement()
                {
                    highest = 20,
                    lowest = 11
                }
            };
            var groupBy = new GroupBy(1);
            var groups = groupBy.Group(measurements);
            Assert.AreEqual(1,groups.Count);
        }

        [TestMethod]
        public void group_by_6number_2()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement()
                {
                    highest = 20,
                    lowest = 11
                },
                new Measurement()
                {
                    highest = 20,
                    lowest = 11
                },
                new Measurement()
                {
                    highest = 20,
                    lowest = 11
                },
                new Measurement()
                {
                    highest = 20,
                    lowest = 11
                },
                new Measurement()
                {
                    highest = 20,
                    lowest = 11
                },
                new Measurement()
                {
                    highest = 20,
                    lowest = 11
                }
            };
            var groupBy = new GroupBy(2);
            var groups = groupBy.Group(measurements);
            Assert.AreEqual(3, groups.Count);
        }

        public void group_by_50number_10()
        {
            var measurements = creatMeasurementList(50);

            var groupBy = new GroupBy(10);
            var groups = groupBy.Group(measurements);

            Assert.AreEqual(5, groups.Count);
        }
    }
}
