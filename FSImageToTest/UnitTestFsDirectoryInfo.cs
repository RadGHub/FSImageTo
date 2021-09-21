using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;
using FSImageToLib;
using System;
using System.Collections.Generic;

namespace FSImageToTest
{
    [TestClass]
    public class UnitTestFsDirectoryInfo
    {
        static DirectoryInfo dinfo = new DirectoryInfo(Environment.CurrentDirectory + "//1");
        static FsDirectoryInfo fsdinfo = new(dinfo);
        static List<FsInfo> list = new List<FsInfo>();
        //public void TriangleRightSquare1()
        //{
        //    //arrange
        //    double c1 = 6;
        //    double c2 = 9;
        //    double hip = 10.81665;
        //    double expected = 27;
        //    //act
        //    Triangle triangle1 = new Triangle();
        //    double actual = triangle1.GetSquare(hip, c2, c1);
        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void GetSize()
        {
            //arrange
            float dirSize = 3.0f;
            //act
            float thisSize = fsdinfo.GetSize();
            //assert
            Assert.AreEqual(dirSize, thisSize);
        }
        [TestMethod]
        public void GetAllDirectoriesAndFiles()
		{
            //arrange
            
            //act
            var newList = fsdinfo.GetAllDirectoriesAndFiles();
            //assert
            Assert.AreEqual(list,newList);
        }
    }
}
