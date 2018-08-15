using System.Collections.Generic.Tree.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessingAnimal2;
using System.Collections.Generic;

namespace UnitTest_GuessingAnimal2
{
    [TestClass]
    public class UnitTestGuessing2
    {
        public class DummyNode : Node<string>
        {
            public DummyNode(string value) : base(value)
            {
                Value = value;
            }
        }

        [TestMethod]
        public void TestADDandSELECT()
        {
            var tataravo = new DummyNode("tataravo");
            var bisavo1 = new DummyNode("bisavo1");
            var bisavo2 = new DummyNode("bisavo2");
            var avo = new DummyNode("avo");
            var neto = new DummyNode("neto");

            var tree = new Tree<DummyNode, string>(tataravo);
            tree.AddLeft(bisavo1);
            tree.AddRight(bisavo2);
            tree.SelectLeft();
            tree.AddLeft(avo);
            Assert.AreEqual(tataravo, bisavo1.Root, "O Nó adicionado à esquerda do Root do bisavo1, é foi definido como o atual selecionado.");

            tree.SelectLeft();
            Assert.AreEqual(tree.CurrentSelected, avo, "O Nó adicionado à esquerda não foi selecionado quando chamada a função SelectLeft.");

            tree.AddRight(neto);
            Assert.AreEqual(tree.CurrentSelected.Right, neto, "O Nó neto adicionado à direita, não foi definido na chamado da funçao.");
        }

        [TestMethod]
        public void TestROOTTREE()
        {
            var tataravo = new DummyNode("tataravo");
            var bisavo1 = new DummyNode("bisavo1");
            var bisavo2 = new DummyNode("bisavo2");
            var avo = new DummyNode("avo");
            var neto = new DummyNode("neto");

            var tree = new Tree<DummyNode, string>(tataravo);

            Assert.AreEqual(tree.CurrentSelected, tataravo, "O Root definido na construtura do Tree não é o mesmo selecionado inicialmente.");
        }
    }
}
