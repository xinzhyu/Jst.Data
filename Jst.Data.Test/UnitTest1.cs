using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jst.Data.Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Ĭ�ϲ���where����
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            var sql = DbSession.Default.From<User>().Where().ToSql();

            Assert.AreEqual("select * from User",sql);

        }

        /// <summary>
        /// ����������ѯ
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            var sql = DbSession.Default.From<User>().Where(1).ToSql();

            Assert.AreEqual("select * from User where Id=1", sql);

        }
    }
}
