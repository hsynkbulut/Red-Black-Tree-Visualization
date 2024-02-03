using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBlackTreeUygulama
{
    public class NodeManager
    {
        static NodeModel _root;
        private static NodeModel _defaultNode;

        public NodeManager()
        {
            _defaultNode = new NodeModel() { Value = 0, NodeColor = NodeColor.black, Level = 0 };
        }

        public bool Search(int value)
        {
            return Search(_root, value);
        }

        private bool Search(NodeModel node, int value)
        {
            while (node != null)
            {
                if (value == node.Value)
                {
                    return true;
                }
                else if (value < node.Value)
                {
                    //node = node.NodeLeftChild;
                    if (node.Value == 0)
                    {
                        return false;
                    }
                    return Search(node.NodeLeftChild, value);
                }
                else if (value > node.Value)
                {
                    if (node.Value == 0)
                    {
                        return false;
                    }

                    //node = node.NodeRightChild;
                    return Search(node.NodeRightChild, value);
                }
                else
                {
                    return false;
                }
            }

            return false;
        }


        public void Record(double value)
        {
            if (_root == null)
            {
                _root = _defaultNode;
                _root.NodeParent = _defaultNode;
                _root.NodeLeftChild = _defaultNode;
                _root.NodeRightChild = _defaultNode;
                _root.Position = new Position() { X = 0, Y = 0 };
                _root.NodeColor = NodeColor.black;
            }
            NodeModel _newNode = new NodeModel() { Value = value, NodeColor = NodeColor.red, Level = 0 };
            NodeModel _nodeHelper = _defaultNode;
            NodeModel _rootHelper = _root;

            while (_rootHelper != _defaultNode)
            {
                _nodeHelper = _rootHelper;
                if (_newNode.Value < _rootHelper.Value)
                {
                    _rootHelper = _rootHelper.NodeLeftChild;
                }
                else
                {
                    if (_newNode.Value > _rootHelper.Value)
                    {
                        _rootHelper = _rootHelper.NodeRightChild;
                    }
                    else return;
                }
            }
            _newNode.NodeParent = _nodeHelper;

            if (_nodeHelper == _defaultNode)
            {
                _root = _newNode;
            }
            else
            {
                if (_newNode.Value < _nodeHelper.Value)
                {
                    _nodeHelper.NodeLeftChild = _newNode;
                }
                else
                {
                    _nodeHelper.NodeRightChild = _newNode;
                }
            }

            _newNode.NodeLeftChild = _defaultNode;
            _newNode.NodeRightChild = _defaultNode;
            _newNode.NodeColor = NodeColor.red;

            if (_newNode.NodeParent != _defaultNode)
            {
                _newNode.Level = _newNode.NodeParent.Level + 1;
            }
            ReDrawTree(_newNode);
            SetPosition(_root);
        }
        private void ReDrawTree(NodeModel _newNode)
        {
            NodeModel nodeHelper = _defaultNode;
            while (_newNode.NodeParent.NodeColor == NodeColor.red)
            {
                if (_newNode.NodeParent == _newNode.NodeParent.NodeParent.NodeLeftChild)
                {
                    nodeHelper = _newNode.NodeParent.NodeParent.NodeRightChild;
                    if (nodeHelper.NodeColor == NodeColor.red)
                    {
                        _newNode.NodeParent.NodeColor = NodeColor.black;
                        nodeHelper.NodeColor = NodeColor.black;
                        _newNode.NodeParent.NodeParent.NodeColor = NodeColor.red;
                        _newNode = _newNode.NodeParent.NodeParent;
                    }
                    else
                    {
                        if (_newNode == _newNode.NodeParent.NodeRightChild)
                        {
                            _newNode = _newNode.NodeParent;
                            RotateLeft(_newNode);
                        }
                        _newNode.NodeParent.NodeColor = NodeColor.black;
                        _newNode.NodeParent.NodeParent.NodeColor = NodeColor.red;
                        RotateRight(_newNode.NodeParent.NodeParent);
                    }
                }
                else
                {
                    nodeHelper = _newNode.NodeParent.NodeParent.NodeLeftChild;
                    if (nodeHelper.NodeColor == NodeColor.red)
                    {
                        _newNode.NodeParent.NodeColor = NodeColor.black;
                        nodeHelper.NodeColor = NodeColor.black;
                        _newNode.NodeParent.NodeParent.NodeColor = NodeColor.red;
                        _newNode = _newNode.NodeParent.NodeParent;
                    }
                    else
                    {
                        if (_newNode == _newNode.NodeParent.NodeLeftChild)
                        {
                            _newNode = _newNode.NodeParent;
                            RotateRight(_newNode);
                        }
                        _newNode.NodeParent.NodeColor = NodeColor.black;
                        _newNode.NodeParent.NodeParent.NodeColor = NodeColor.red;
                        RotateLeft(_newNode.NodeParent.NodeParent);
                    }
                }
            }
            _root.NodeColor = NodeColor.black;
            _root.Position = new Position() { X = 0, Y = 0 };
        }
        private void RotateLeft(NodeModel _node)
        {
            NodeModel _nodeHelper = _node.NodeRightChild;
            _node.NodeRightChild = _nodeHelper.NodeLeftChild;
            if (_nodeHelper.NodeLeftChild != _defaultNode)
            {
                _nodeHelper.NodeLeftChild.NodeParent = _node;
            }

            _nodeHelper.NodeParent = _node.NodeParent;
            if (_node.NodeParent == _defaultNode)
            {
                _root = _nodeHelper;
            }
            else
            {
                if (_node == _node.NodeParent.NodeLeftChild)
                {
                    _node.NodeParent.NodeLeftChild = _nodeHelper;
                }
                else
                {
                    _node.NodeParent.NodeRightChild = _nodeHelper;
                }
            }
            _nodeHelper.NodeLeftChild = _node;

            _node.NodeParent = _nodeHelper;

            _node.Level += 1;
            _nodeHelper.Level -= 1;
            DecreaseLevel(_nodeHelper.NodeRightChild);
            IncreaseLevel(_node.NodeLeftChild);
        }
        private void RotateRight(NodeModel _node)
        {
            NodeModel _nodeHelper = _node.NodeLeftChild;
            _node.NodeLeftChild = _nodeHelper.NodeRightChild;
            if (_nodeHelper.NodeRightChild != _defaultNode)
            {
                _nodeHelper.NodeRightChild.NodeParent = _node;
            }

            _nodeHelper.NodeParent = _node.NodeParent;
            if (_node.NodeParent == _defaultNode)
            {
                _root = _nodeHelper;
            }
            else
            {
                if (_node == _node.NodeParent.NodeRightChild)
                {
                    _node.NodeParent.NodeRightChild = _nodeHelper;
                }
                else
                {
                    _node.NodeParent.NodeLeftChild = _nodeHelper;
                }
            }
            _nodeHelper.NodeRightChild = _node;
            _node.NodeParent = _nodeHelper;

            _nodeHelper.Level -= 1;
            _node.Level += 1;
            DecreaseLevel(_nodeHelper.NodeLeftChild);
            IncreaseLevel(_node.NodeRightChild);
        }

        private void IncreaseLevel(NodeModel _node)
        {
            if (_node != _defaultNode && _node != _root)
            {
                _node.Level += 1;
                IncreaseLevel(_node.NodeLeftChild);
                IncreaseLevel(_node.NodeRightChild);
            }
        }
        private void DecreaseLevel(NodeModel _node)
        {
            if (_node != _defaultNode)
            {
                _node.Level -= 1;
                DecreaseLevel(_node.NodeLeftChild);
                DecreaseLevel(_node.NodeRightChild);
            }
        }
        public void SetPosition(NodeModel _node)
        {
            if (_root.NodeLeftChild != _defaultNode) { _root.NodeLeftChild.Position = new Position() { X = -300, Y = 50 }; }
            if (_root.NodeRightChild != _defaultNode) { _root.NodeRightChild.Position = new Position() { X = 300, Y = 50 }; }

            if (_node != _root && _node != _root.NodeLeftChild && _node != _root.NodeRightChild)
            {
                if (_node.Value < _node.NodeParent.Value)
                {
                    _node.Position = new Position() { X = _node.NodeParent.Position.X - _root.NodeRightChild.Position.X / (_node.Level * 2 - _node.Level), Y = _node.NodeParent.Position.Y + 50 };
                }
                else
                {
                    _node.Position = new Position() { X = _node.NodeParent.Position.X + _root.NodeRightChild.Position.X / (_node.Level * 2 - _node.Level), Y = _node.NodeParent.Position.Y + 50 };
                }
            }
            if (_node.NodeLeftChild != _defaultNode)
            {
                SetPosition(_node.NodeLeftChild);
            }
            if (_node.NodeRightChild != _defaultNode)
            {
                SetPosition(_node.NodeRightChild);
            }
        }
        //Ağaçtan sil
        private NodeModel GetDeletableNode(double value, NodeModel _node)
        {
            NodeModel _defaultReturnValue = _defaultNode;
            if (value == _node.Value) return _node;
            if (_node != _defaultNode)
            {
                if (value < _node.Value)
                {
                    _defaultReturnValue = GetDeletableNode(value, _node.NodeLeftChild);
                }
                else
                {
                    _defaultReturnValue = GetDeletableNode(value, _node.NodeRightChild);
                }
            }
            else
            {
                MessageBox.Show("Ağaç bu sayıyı içermiyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return _defaultReturnValue;
        }
        public void DeleteNode(double value)
        {
            NodeModel _deletableNode = GetDeletableNode(value, _root);
            if (_deletableNode == _defaultNode) return;
            NodeModel item = _deletableNode;
            NodeModel X = _defaultNode;
            NodeModel Y = _defaultNode;

            if (item.NodeLeftChild == _defaultNode|| item.NodeRightChild== _defaultNode)
            {
                Y = item;
            }
            else
            {
                Y = TreeSuccessor(item);
            }
            if (Y.NodeLeftChild != _defaultNode)
            {
                X = Y.NodeLeftChild;
            }
            else
            {
                X = Y.NodeRightChild;
            }
            if (X != _defaultNode)
            {
                X.NodeParent= Y;
            }
            if (Y.NodeParent == _defaultNode)
            {
                _root = X;
            }
            else if (Y == Y.NodeParent.NodeLeftChild)
            {
                Y.NodeParent.NodeLeftChild= X;
            }
            else
            {
                Y.NodeParent.NodeLeftChild= X;
            }
            if (Y != item)
            {
                item.Value= Y.Value;
            }
            X.NodeColor = NodeColor.black;
                DeleteFixUp(X);
            SetPosition(_root);
        }

        private void DeleteFixUp(NodeModel X)
        {

            while (X != _defaultNode && X != _root && X.NodeColor == NodeColor.black)
            {
                if (X == X.NodeParent.NodeLeftChild)
                {
                    NodeModel W = X.NodeParent.NodeRightChild;
                    if (W.NodeColor == NodeColor.red)
                    {
                        W.NodeColor = NodeColor.black; 
                        X.NodeParent.NodeColor = NodeColor.red; 
                        RotateLeft(X.NodeParent); 
                        W = X.NodeParent.NodeRightChild; 
                    }
                    if (W.NodeLeftChild.NodeColor == NodeColor.black && W.NodeRightChild.NodeColor == NodeColor.black)
                    {
                        W.NodeColor = NodeColor.red; 
                        X = X.NodeParent; 
                    }
                    else if (W.NodeRightChild.NodeColor == NodeColor.black)
                    {
                        W.NodeLeftChild.NodeColor = NodeColor.black; 
                        W.NodeColor = NodeColor.red; 
                        RotateRight(W); 
                        W = X.NodeParent.NodeRightChild; 
                    }
                    W.NodeColor = X.NodeParent.NodeColor; 
                    X.NodeParent.NodeColor = NodeColor.black; 
                    W.NodeRightChild.NodeColor = NodeColor.black; 
                    RotateLeft(X.NodeParent); 
                    X = _root; 
                }
                else 
                {
                    NodeModel W = X.NodeParent.NodeLeftChild;
                    if (W.NodeColor == NodeColor.red)
                    {
                        W.NodeColor = NodeColor.black;
                        X.NodeParent.NodeColor = NodeColor.red;
                        RotateRight(X.NodeParent);
                        W = X.NodeParent.NodeLeftChild;
                    }
                    if (W.NodeRightChild.NodeColor == NodeColor.black && W.NodeLeftChild.NodeColor == NodeColor.black)
                    {
                        W.NodeColor = NodeColor.black;
                        X = X.NodeParent;
                    }
                    else if (W.NodeLeftChild.NodeColor == NodeColor.black)
                    {
                        W.NodeRightChild.NodeColor = NodeColor.black;
                        W.NodeColor = NodeColor.red;
                        RotateLeft(W);
                        W = X.NodeParent.NodeLeftChild;
                    }
                    W.NodeColor = X.NodeParent.NodeColor;
                    X.NodeParent.NodeColor = NodeColor.black;
                    W.NodeLeftChild.NodeColor = NodeColor.black;
                    RotateRight(X.NodeParent);
                    X = _root;
                }
            }
            if (X != _defaultNode)
                X.NodeColor = NodeColor.black;
        }
        private NodeModel Minimum(NodeModel X)
        {
            while (X.NodeLeftChild.NodeLeftChild != _defaultNode)
            {
                X = X.NodeLeftChild;
            }
            if (X.NodeLeftChild.NodeRightChild != _defaultNode)
            {
                X = X.NodeLeftChild.NodeRightChild;
            }
            return X;
        }
        private NodeModel TreeSuccessor(NodeModel X)
        {
            if (X.NodeLeftChild != _defaultNode)
            {
                return Minimum(X);
            }
            else
            {
                NodeModel Y = X.NodeParent;
                while (Y != _defaultNode && X == Y.NodeRightChild)
                {
                    X = Y;
                    Y = Y.NodeParent;
                }
                return Y;
            }
        }
        public NodeModel Get()
        {
            return _root;
        }
        public NodeModel GetDefault()
        {
            return _defaultNode;
        }

        public void PreorderTraversal(ListBox listBox)
        {
            PreorderTraversal(_root, listBox);
        }

        private void PreorderTraversal(NodeModel node, ListBox listBox)
        {
            if (node != null)
            {
                listBox.Items.Add(node.Value);

                if (node.NodeLeftChild != null && node.NodeLeftChild.Value != 0)
                    PreorderTraversal(node.NodeLeftChild, listBox);

                if (node.NodeRightChild != null && node.NodeRightChild.Value != 0)
                    PreorderTraversal(node.NodeRightChild, listBox);
            }
        }


        public void InorderTraversal(ListBox listBox)
        {
            InorderTraversal(_root, listBox);
        }

        private void InorderTraversal(NodeModel node, ListBox listBox)
        {

            if (node != null)
            {              
                if (node.NodeLeftChild != null && node.NodeLeftChild.Value != 0)
                    InorderTraversal(node.NodeLeftChild, listBox);

                listBox.Items.Add(node.Value);

                if (node.NodeRightChild != null && node.NodeRightChild.Value != 0)
                    InorderTraversal(node.NodeRightChild, listBox);
            }

        }

        public void PostorderTraversal(ListBox listBox)
        {
            PostorderTraversal(_root, listBox);
        }

        private void PostorderTraversal(NodeModel node, ListBox listBox)
        {
            if (node != null)
            {
                if (node.NodeLeftChild != null && node.NodeLeftChild.Value != 0)
                    PostorderTraversal(node.NodeLeftChild, listBox);

                if (node.NodeRightChild != null && node.NodeRightChild.Value != 0)
                    PostorderTraversal(node.NodeRightChild, listBox);

                listBox.Items.Add(node.Value);
            }
        }

    }
}
