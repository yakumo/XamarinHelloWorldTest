using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace XamarinHelloWorldApp
{
    public class MainData : BindableObject
    {
        static MainData _instance = null;
        public static MainData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainData();
                }
                return _instance;
            }
        }

        public MainData()
        {
            try
            {
                
                var asm = Assembly.GetAssembly(typeof(MainData));
                using (var f = asm.GetManifestResourceStream("XamarinHelloWorldApp.source.json"))
                {
                    using (var s = new StreamReader(f))
                    {
                        var json = s.ReadToEnd();
                        Bookshelves = JsonConvert.DeserializeObject<List<Bookshelf>>(json);
                        SelectedBookshelf = Bookshelves[0];
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void OnPropertyChange(string propertyName, Action propertyChangeAction)
        {
            OnPropertyChanging(propertyName);
            propertyChangeAction.Invoke();
            OnPropertyChanged(propertyName);
        }

        [JsonProperty("Bookshelf")]
        public List<Bookshelf> Bookshelves { get; set; }

        private Bookshelf _selectedBookshelf;
        public Bookshelf SelectedBookshelf
        {
            get => _selectedBookshelf;
            set
            {
                OnPropertyChange("SelectedBookshelf", () => { _selectedBookshelf = value; });
            }
        }
    }

    public class Bookshelf
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Titles")]
        public List<BookTitle> Titles { get; set; }
    }

    public class BookTitle
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Thumbnail")]
        public string Thumbnail { get; set; }
    }
}
