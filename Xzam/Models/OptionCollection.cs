using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Xzam.Models
{
    public class OptionCollection : IEnumerable
    {
        private List<Option> options;

        public OptionCollection()
        {
            options = new List<Option>();
        }
        public OptionCollection(Option[] options)
        {
            this.options = new List<Option>();
            this.options.AddRange(options);

        }
        public List<Option> ToList()
        {
            return this.options;
        }
        public OptionCollection(List<Option> options)
        {

            this.options = options;

        }
        public void AddOption(char code, String value)
        {
            foreach (Option opt in options)
            {
                if (opt.Code.Equals(code))
                {
                    throw new Exception("Option with the same code already exists");
                }
            }
            options.Add(new Option(code, value,null));
        }
        public void AddOption(Option option)
        {
            foreach (Option opt in options)
            {
                if (opt.Code.Equals(option.Code))
                {
                    throw new Exception("Option with the same code already exists");
                }
            }
            options.Add(option);
        }
        public void RemoveOption(String code)
        {
            int i = 0;
            foreach (Option opt in options)
            {
                if (opt.Code.Equals(code))
                {
                    options.RemoveAt(i);
                    break;
                }
                ++i;
            }
        }
        public void AddOptionRange(IEnumerable<Option> collection)
        {
            if (collection != null)
            {

                options.AddRange(collection);
            }
        }

        public void AddOptionRange(OptionCollection collection)
        {
            if (collection != null)
            {
                options.AddRange(collection.ToList());
            }
        }
        public void Clear()
        {
            options.Clear();
        }

        public int Count
        {
            get
            {
                return options.Count;
            }

        }

        // for non generic iteration
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < options.Count; i++)
            {
                yield return (options[i]);
            }
        }

    }
}
