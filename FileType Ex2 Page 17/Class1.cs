using System;
using System.Collections.Generic;
using System.Text;

namespace FileType_Ex2_Page_17
{
    public class FileManger
    {
        private string type;
        private string name;
        private double size;
        private double date;
        private bool   isOpen;
        private string content;

        //ctors
        public FileManger(string type, string name, double size, double date, bool isOpen,string content) 
        {
            this.type =type;
            this.name =name;
            this.size =size;
            this.date =date;
            this.isOpen =isOpen;
            this.content =content;
        }
        //setters
        public void SetType(string type) 
        {
            this.type =type;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSize(double size) 
        {
            this.size = size; 
        }
        public void OpenFile()
        {
            this.isOpen = true;
        }
        public void CloseFile()
        {
            this.isOpen = false;
        }
        public void UpdateContent(string content)
        {
            this.content=content;
        }
        //getters
        public string GetFileType() 
        {
            return this.type; 
        }
        public string GetName() 
        {
            return this.name;
        }
        public double GetSize()
        {
            return this.size;
        }
        public double GetDate()
        {
            return this.date;
        }
        public bool IsOpen()
        {
            return this.isOpen;
        }
        public string GetContent()
        {
            return this.content;
        }
        public bool IsSameType(FileManger other)
        {
            if (this.type == other.type)
            {
                return true;
            }
            return false;
        }
        
    }
}
