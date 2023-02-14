# 'Screw Me Up' /L : Under New Management

**Screw Me Up** intentionally tries to Screw Up Unity's `Monobehaviour`s and KSP's `PartModule`'s live cycles.

**Screw Me Up /L** is Lisias' management screwing you up - intentionally, this time!


## Installation Instructions

To install, place the GameData folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
	+ Delete `<KSP_ROOT>/GameData/ScrewMeUp`
* Extract the package's `GameData/` folder into your KSP's as follows:
	+ `<PACKAGE>/GameData/ScrewMeUp ` --> `<KSP_ROOT>/GameData`
		- Overwrite any preexisting file.

The following file layout must be present after installation:

```
<KSP_ROOT>
	[GameData]
		[ScrewMeUp]
			[Plugins]
				...
			[patches]
				...
			CHANGE_LOG.md
			LICENSE
			NOTICE
			README.md
			ScrewMeUp
		ModuleManager.dll
		...
	KSP.log
	PartDatabase.cfg
	...
```


### Dependencies

* Module Manager 3.1.3 or later
	+ **Not Included**
