using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Foundation;

namespace YetAnotherAppIOS
{
    public class Monkeys : List<Monkeys.Monkey>
    {
        static readonly Monkeys monkeys = new Monkeys ();

        Monkeys ()
        {
            Regex pattern = new Regex (@"^.*\.(jpg)$", RegexOptions.IgnoreCase);
            string path = NSBundle.MainBundle.BundlePath;

            Directory.GetFiles (path).Where (f => pattern.IsMatch (f)).ToList ().ForEach (p => {
                var item = new Monkey{ ImageFile = Path.GetFileName (p) };
                Add (item);
            });
        }

        public static Monkeys Instance {
            get {
                return monkeys;
            }
        }

        public class Monkey
        {
            public string ImageFile { get; set; }
        }
    }
} 