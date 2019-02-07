using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06_1
{
    class Stack
    {
        private int[] _list;
        private bool _isEmpty;
        private int _count;
        private bool _isSetSize;

        public bool IsEmpty
        {
            get
            {
                return _isEmpty;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public Stack(int length)
        {
            _isSetSize = true;
            _isEmpty = true;
            _count = 0;
            _list = new int[length];
            
        }

        public Stack()
        {
            _isSetSize = false;
            _count = 0;
            _isEmpty = true;          
        }

        public bool Push(int item)
        {
            if(_isSetSize)
            {
                if (_list.Length != _count)
                {
                    _isEmpty = false;
                    _list[_count] = item;
                    _count++;
                    return true;
                }
                else
                {
                    Console.WriteLine("Stack overflow!");
                    return false;
                }
            }
            else
            {
                if(_isEmpty)
                {
                    _isEmpty = false;
                    _list = new int[1];
                    _list[0] = item;
                    _count++;
                }
                else
                {
                    _isEmpty = false;
                    int[] _newList = new int[_list.Length + 1];

                    for (int i = 0; i < _list.Length; i++)
                    {
                        _newList[i] = _list[i];
                    }

                    _newList[_list.Length] = item;
                    _list = _newList;
                    _count++;
                }

                return true;
            }
            
            
        }

        public int Pop()
        {
            if(!_isEmpty)
            {
                int _value;

                if (_isSetSize)
                {
                    _value = _list[_count - 1];
                }
                else
                {
                    _value = _list[_list.Length - 1];

                    int[] _newList = new int[_list.Length - 1];

                    for (int i = 0; i < _newList.Length; i++)
                    {
                        _newList[i] = _list[i];
                    }

                    _list = _newList;                
                }

                _count--;

                if (_count == 0)
                {
                    _isEmpty = true;
                }

                return _value;
            }
            else
            {
                Console.WriteLine("Stack is empty.");
                return 0;
            }            
        }

        public int Peek()
        {
            if(_isSetSize)
            {
                return _list[_count - 1];
            }
            else
            {
                return _list[_list.Length - 1];
            }            
        }
    }
}
