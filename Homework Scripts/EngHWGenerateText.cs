using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class EngHWGenerateText : MonoBehaviour {

	public int wordCountLowerBound;
	public int wordCountUpperBound;
	string text;
    public string content;
	//string content;
	public string[] assignmentWords; //the words that show up on the homework sprite that get copied
	
	// Use this for initialization
	void Start()
	{
		GameController controller = GameObject.Find("GameController").GetComponent<GameController>();
		wordCountLowerBound = controller.minWordsAccess;
		wordCountUpperBound = controller.maxWordsAccess;
		//setContent();
		//what was here previously is in the willIsAnIdiot() method now
		willIsAnIdiot();

        //content = "a b c";
		
	}
    void willIsAnIdiot()
    {
        //sets length of assignmentWords to the max words


        int wordCount = Random.Range(wordCountLowerBound, wordCountUpperBound);
        assignmentWords = new string[wordCount];
        /*//all the stuff below was causing the game to break when uploaded to itch.io
        string path;
		FileStream fs;
        string content;

        //this is for paths to be different
		try {

			path = Application.dataPath + "/Assets/Resources/WordsLvl2.txt"; //for the build
			fs = new FileStream(path, FileMode.Open);
		} catch {
			path = "Assets/Resources/WordsLvl2.txt"; //for testing in unity
			fs = new FileStream(path, FileMode.Open);
		}
		string content = "";
		using (StreamReader read = new StreamReader(fs, true))
		{
			content = read.ReadToEnd();
		}
        */
        //string[] words = Regex.Split(content, " ", RegexOptions.Singleline);

        string[] words = {"the","and","that","have","eye","for","with","from","abundant","acumulate","accurate","more",
        "all","must","serve","owl","will","would","there","their","what","about","when","make","can","time","people",
            "into", "year","good","your","them","other","also","think","work","even","because","any","these","most",
            "sway","thing","hand","child","life","man","woman","place","case","number","company","group","problem","point",
        "government","fact","important","fake","real","depressed","failure","special","monotone","boredom","canvas",
        "log","truck","trailer","car","train","plane","phone","television","defenistrate","public","gross","arms","feet",
        "legs","meal","hand","court","jury","race","neutral","popular","singer","police","deer","dragon","elf","movie",
        "monitor","film","war","game","soup","chicken","mouse","cow","moose","cow","rat","painting","dog","cat","kitten",
        "puppy","computer","pet","meme","sour","bitter","sweet","seat","heat","iron","carbon","metal","music","guitar",
        "piano","ace","act","air","water","earth","fire","troll","art","ash","meat","snake","fox","hue","ion","common",
            "rare","epic","legendary","machine","fight","dream","wear","clothes","shirt","jacket","shoes","pants","socks",
        "mop","penguin","bear","pot","cowl","coral","plant","leaf","tree","rotten","sentence","spell","three","four",
            "five","six","seven","eight","nine","ten","cover","play","read","write","large","layer","marble","granite",
        "land","said","follow","change","light","darkness","pizza","coffee","avocado","apple","banana","house","crate",
            "animal","again","require","assistance","create","farther","father","mother","dead","stand","page","homework",
            "country","sound","found","school","extra","commitment","grow","between","ticket","little","draw","press",
        "under","lord","stop","please","brawl","night","sword","space","lazer","together","hatch","ship","against","begin",
        "center","love","hate","always","money","cards","science","letter","rule","until","govern","missile","snow","ball",
            "river","stream","steam","notice","file","care","certain","mountain","hill","north","south","east","west","plan",
            "once","boar","bore","star","planet","field","watch","color","correct","incorrect","unacceptable","acceptable",
        "misunderstood","understood","contain","weird","cruel","front","young","teacher","student","radio","cord","floor",
            "ceiling","whale","wall","enemy","automatic","beauty","sparkle","shine","cereal","sandwich","salad","green","orange",
            "advanced","placement","test","usual","ready","final","gave","grade","list","though","quick","smile","frown",
        "yellow","purple","strong","weak","feeble","power","knowledge","key","code","direct","nose","mind","aim","punch",
        "munch","crunch","magazine","office","table","chair","paper","news","product","street","question","complete",
        "avenue","force","magnitude","direction","vector","gravity","fall","throne","axe","blue","area","numeral","moon",
        "flame","bubble","burn","cauldron","island","piece","peace","record","guitar","violin","viola","trumpet","bass",
            "treble","smooth","cell","rough","flute","tuba","tuna","recall","watch","farm","thousand","milion","billion",
        "thunder","typhoon","hurricane","tornado","flood","halo","navy","army","marine","remember","ground","interest",
        "heal","roll","bulldoze","demolish","demon","witch","care","wolf","perhaps","travel","speech","represent","eminent",
        "language","mourning","morning","flower","rose","bud","ruby","scythe","continent","content","fill","weight","pound",
        "niche","english","reserved","class","object","player","weapon","skill","luck","lottery","college","application",
        "bat","battery","status","assets","level","project","less","remind","spot","discord","mayonaise","fort","swift",
        "box","bait","launch","catapult","castle","rogue","knight","king","queen","strike","bat","mill","store","grocery",
        "stem","petal","screech","yell","scream","pumpkin","spider","insect","blaze","mist","ice","blizzard","coin","dollar",
        "fence","bush","brush","bramble","hieroglyph","metropolitan","control","battle","inferno","ember","wave","beach",
        "craft","capture","restore","deal","gangster","bullet","dungeon","heaven","cloud","fairy","miniature","carrier",
        "bloat","blame","politician","republic","state","powder","dough","smash","crush","melee","cork","magic","gather",
        "hearth","stone","mine","rule","ring","marriage","achieve","acquire","address","allegiance","divergence","insurgent",
        "amateur","annually","believe","camouflage","category","cemetery","chief","committed","concede","conscious",
        "insurance","deceive","disastrous","embarrass","equipment","exhilarate","exceed","fascinating","fiery","gauge",
        "guarantee","height","hierarchy","humorous","hygiene","hypocrisy","ignorance","bliss","independent","indispensable",
        "inoculate","intelligence","jewelry","judgement","kernel","colonel","leisure","liason","license","scissors",
        "minuscule","misspell","niece","mischievous","occurrence","omission","original","inception","redacted","outrageous",
        "parliament","potatoes","presence","precede","privilege","professor","proof","publicly","queue","questionnaire",
        "readable","recommend","reference","repetition","restaurant","controls","secretary","rhythm","sergeant","similar",
        "supersede","synonymous","tomatoes","tomorrow","twelth","tyranny","upholstery","vacuum","vehicle","weather",
        "welfare","social","security","amendment","constitution","withhold","wiry","seize","bread","copy","affirmative",
        "index","debug","religious","breakfast","midnight","noon","revolve","spin","deceit","angel","demon","peninsula",
        "holy","sancrosact","quarantine","quiz","affiliation","director","enforcer","tight","loose","lose","loss","fog",
            "strategy","crystal","charge","rush","steal","burgle","bully","technology","oligarch","pick","ocean","maid",
        "rope","escape","revenge","friends","fever","drug","smoke","picture","lion","tiger","immortal","champion","sky",
        "bond","range","scope","purview","warrior","fake","assign","mentor","cup","plate","wash","teeth","brush","dry",
        "wet","basin","boss","path","edge","kingdom","line","lame","broth","feeling","mighty","song","beat","juice",
        "dairy","diary","moss","gather","stick","spear","arrow","long","float","string","enjoy","pillow","bed","idle",
            "development","software","unity","fine","folder","vote","elect","amplified","damp","dank","swarm","horde",
            "apart","colony","peace","mantis","loan","bank","sea","lake","sandy","plank","lamp","vase","dude","cross",
        "piano","drum","football","soccer","sting","bee","date","month","year","resume","twitch","message","tune"};




		int currentWordIndex = 0;
		Debug.Log (words);
		text = "";
		for (int i = 0; i < wordCount; i++)
		{
			currentWordIndex = Random.Range(0, words.Length - 1);
			text += words[currentWordIndex];
			assignmentWords[i] = words[currentWordIndex]; //adds the word that was added to the string to the array
			//Debug.Log(assignmentWords[i]);
			if (i != wordCount - 1)
				text += " ";
		}
		
		//Text display = transform.parent.GetChild (C:\Users\saksh\Documents\12 Years a Student\Assets\Scripts\EngHWGenerateText.cstransform.GetSiblingIndex () + 1).gameObject.GetComponent<Text>();
		//Debug.Log (display);
		GetComponent<Text>().text = text;
		
		
	}
	
	public string getAnswer()
	{
		return text;
	}
	
	private void setContent()
	{
		//content = "";
	}
}
