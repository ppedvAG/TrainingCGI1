using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCGI1.Pages
{
    public class ChatVM
    {
        public Action OnAdd;
        public List<string> ChatListe { get; set; } = new List<string>();
        public void Add(string msg)
        {
            ChatListe.Add(msg);
            OnAdd?.Invoke();

        }
    }
}
