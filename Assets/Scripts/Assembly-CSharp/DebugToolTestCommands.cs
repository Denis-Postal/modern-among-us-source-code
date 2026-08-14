using Innersloth.DebugTool;
using UnityEngine;

public class DebugToolTestCommands : MonoBehaviour
{
	public enum DogTypes
	{
		GoldenRetriever = 0,
		BlackLab = 1,
		GermanShepherd = 2,
		Husky = 3
	}

	public enum CatTypes
	{
		HouseCat = 0,
		Panther = 1,
		Bobcat = 2,
		Meercat = 3
	}

	public enum EggStyle
	{
		Fried = 0,
		OverEasy = 1,
		OverMedium = 2,
		OverHard = 3,
		Scrambled = 4,
		SunnySideUp = 5
	}

	public enum BreakfastSide
	{
		None = 0,
		Beans = 1,
		Fries = 2,
		Fruit = 3,
		Hashbrowns = 4,
		Sausages = 5
	}

	[SerializeField]
	private DebugToolOverlay overlay;

	[SerializeField]
	private bool testLogsOnStartup;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void LogABunchOfRandomStuff()
	{
	}

	[DebugCommand("Thing/Animal/Ape/Baboon", null, false)]
	public static void ThingAnimalApeBaboon()
	{
	}

	[DebugCommand("Thing/Animal/Ape/Chimpanzee", null, false)]
	public static void ThingAnimalApeChimpanzee()
	{
	}

	[DebugCommand("Thing/Animal/Bear", null, false)]
	public static void ThingAnimalBear()
	{
	}

	[DebugCommand("Thing/Animal/Cat", null, false)]
	public static void ThingAnimalCat([DebugParameter("House Cat, Bobcat, Panther, etc..")] CatTypes catType)
	{
	}

	[DebugCommand("Thing/Animal/Dog", null, false)]
	public static void ThingAnimalDog([DebugParameter("Golden, German Shepherd, Black Lab etc..")] DogTypes dogType)
	{
	}

	[DebugCommand("Thing/Animal/Human", null, false)]
	public static void ThingAnimalHuman()
	{
	}

	[DebugCommand("Thing/Fruit/Apple", null, false)]
	public static void ThingFruitApple([DebugParameter("Red Delicions, Gala, etc")] string type)
	{
	}

	[DebugCommand("Thing/Fruit/Banana", null, false)]
	public static void ThingFruitBanana([DebugParameter("Inches: 2.4")] float inches, [DebugParameter("0 - 1")] float ripeness)
	{
	}

	[DebugCommand("Thing/Fruit/Citrus", null, false)]
	public static void ThingFruitCitrus()
	{
	}

	[DebugCommand("Thing/Fruit/Durian", null, false)]
	public static void ThingFruitDurian()
	{
	}

	[DebugCommand("Thing/Rainbow", null, false)]
	public static void Rainbow()
	{
	}

	[DebugCommand("Bacon and Eggs", "This is a breakfast food that many enjoy. Asks how many pieces of bacon, what style of eggs, and what kind of side you'd like. Note: You MUST say 'yes' to Avocado Toast.", false)]
	public static void BaconAndEggs([DebugParameter("1 - 100")] int bacon, EggStyle eggStyle, BreakfastSide side, [DebugParameter("YES")] string avocadoToast)
	{
	}

	[DebugCommand("Error/Throw an exception", null, false)]
	public static void ThrowAnException()
	{
	}

	[DebugCommand("Error/Display a LogCommandError", null, false)]
	public static void LogCommandError()
	{
	}

	[DebugCommand("More/Commands/Here", null, false)]
	public static void MoreCommandsHere()
	{
	}

	[DebugCommand("More/Commands/There", null, false)]
	public static void MoreCommandsThere()
	{
	}

	[DebugCommand("More/Commands/Everywhere", null, false)]
	public static void MoreCommandsEverywhere()
	{
	}

	[DebugCommand("Cosmetics/Test Hat", null, false)]
	public static void TestHat([DebugParameter("Hat ID")] HatData hat)
	{
	}

	[DebugCommand("Cosmetics/Test Visor", null, false)]
	public static void TestVisor([DebugParameter("Visor ID")] VisorData visor)
	{
	}

	[DebugCommand("Cosmetics/Test Skin", null, false)]
	public static void TestSkin([DebugParameter("Skin ID")] SkinData skin)
	{
	}

	[DebugCommand("Cosmetics/Test Pet", null, false)]
	public static void TestPet([DebugParameter("Pet ID")] PetData pet)
	{
	}
}
