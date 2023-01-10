using Common;
using Trees;

#region Generic tree
//Console.WriteLine("Working with generic trees");
//var tree = new GenericTree();
//var root = tree.Insert("A", null);

//var temp = tree.Insert("B", root);
//tree.Insert("E", temp);

//tree.Insert("C", root);

//temp = tree.Insert("D", root);
//tree.Insert("F", temp);
//tree.Insert("G", temp);
//tree.Insert("H", temp);
//tree.Insert("J", temp);

//Console.WriteLine("PreOrder traverse");
//tree.TraversePreOrder(root);
//Console.WriteLine("**********");
//Console.WriteLine("PostOrder traverse");
//tree.TraversePostOrder(root);
//Console.WriteLine("**********");

//Console.WriteLine("Search value:");
//TreeNode result = tree.Search("F", root);
//if (result is not null)
//{
//    Console.WriteLine(result.Data);
//}
//else
//{
//    Console.WriteLine("Node not found");
//}
//Console.WriteLine("**********");

//Console.WriteLine("A more convenient way to insert nodes is to indicate on which node you want to insert");
//Console.WriteLine("Indicate new node data: ");
//string newNodedata = Console.ReadLine();
//Console.WriteLine("Indicate the value of the node where you want to insert the new node: ");
//string valueNodeToInsertInto = Console.ReadLine();
//var nodeToInserInto = tree.Search(valueNodeToInsertInto, root);
//if (nodeToInserInto is not null)
//{
//    tree.Insert(newNodedata, nodeToInserInto);
//}
//tree.TraversePreOrder(root);
#endregion

#region Search Binary tree
Console.WriteLine("Working with Search Binary trees");
var sbtree = new SearchBinaryTree<int>();
var sbroot = sbtree.Insert(25, null);

sbtree.Insert(15, sbroot);
sbtree.Insert(50, sbroot);
sbtree.Insert(10, sbroot);
sbtree.Insert(22, sbroot);
sbtree.Insert(35, sbroot);
sbtree.Insert(70, sbroot);
sbtree.Insert(31, sbroot);
sbtree.Insert(44, sbroot);
sbtree.Insert(90, sbroot);
sbtree.Insert(66, sbroot);
sbtree.Insert(12, sbroot);
sbtree.Insert(4, sbroot);
sbtree.Insert(18, sbroot);
sbtree.Insert(24, sbroot);
//var sbroot = sbtree.Insert(6, null);

//sbtree.Insert(2, sbroot);
//sbtree.Insert(8, sbroot); 
//sbtree.Insert(1, sbroot); 
//sbtree.Insert(4, sbroot);
//sbtree.Insert(3, sbroot);
//sbtree.Insert(5, sbroot);
//sbtree.Insert(7, sbroot);
//sbtree.Insert(11, sbroot);
//sbtree.Insert(9, sbroot);
//sbtree.Insert(10, sbroot);
//sbtree.Insert(0, sbroot);
//sbtree.Insert(-1, sbroot);
//sbtree.Insert(12, sbroot);
//sbtree.Insert(14, sbroot);

sbtree.TraversePreOrder(sbroot);
#endregion



