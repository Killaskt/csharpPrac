using System;

namespace Defining
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have member variables, or "fields" to hold data
        string _name; // underscore is the naming scheme for a internal var
        string _author;
        int _pagecount;

        // TODO: classes have one or more constructors
        public Book (string name, string author, int pagecount) {
            _name = name;
            _author = author;
            _pagecount = pagecount;
        }


        // TODO: methods are used to operate on the class and data
        public string getDescription () {
            return $"{_name} by {_author}, {_pagecount} pages";
        } 

        public string GetName () {
            return _name;
        }
        public void SetName (string name) {
            _name = name;
        }
        public string GetAuthor () {
            return _author;
        }
        public void SetAuthor (string author) {
            _author = author;
        }
        public int GetPageCount () {
            return _pagecount;
        }
        public void SetPageCount (int pagecount) {
            _pagecount = pagecount;
        }

    }
}
