using System;

public class Reference {
    public string _scriptureReference;
    public string _scriptureVersStart;
    public string _scriptureVersEnd;

    public string[] _scripture1 = {"John 3:16", 
    "For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."};
    public string[] _scripture2 = {"Proverbs 3:5-6", 
    "Trust in the Lord with all thine heart; and lean not unto thine own understanding.", 
    "In all thy ways acknowledge him, and he shall direct thy paths."};
    

    public Reference() {
        
        List<string> scriptures = new List<string>(_scripture1);
    }
    
}

//class ScriptureReference {
//        public string _scriptureReference {get; set; }
//        public string _scriptureVersStart {get; set; }
//        public string _scriptureVersEnd {get; set; }
//    }
    
//    class ScriptureDictionary {
        
//        static Dictionary<int, ScriptureReference> _scripture = new Dictionary<int, ScriptureReference>()
//        {   
//            {1, new ScriptureReference {_scriptureReference="John 3:16", _scriptureVersStart="For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."}},
//            {2, new ScriptureReference {_scriptureReference="Proverbs 3:5-6", _scriptureVersStart="Trust in the Lord with all thine heart; and lean not unto thine own understanding.", _scriptureVersEnd="In all thy ways acknowledge him, and he shall direct thy paths."}},
//        };
//    }
