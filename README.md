# NPCTokens
Adds custom tokens for NPC data, including display name, gender, birthdays, and disposition information (optimism, manners, socialAnxiety, etc.).

NPC Tokens for Content Patcher adds the custom token `siliconmodding.NPCTokens/NPC:`, which takes two arguments separated by a plus sign (+): the target NPC's name (not DisplayName), and the information you want a token of. A token missing an NPC name argument will return an empty string.

For example, `siliconmodding.NPCTokens/NPC:Alex+Gender` will return Alex's gender.

Note that these tokens will not work when used through aliases (so yes, you will normally need to copy/paste `siliconmodding.NPCTokens/NPC:Abigail+Birthday_Season` whenever you want to find out Abigail was born in fall). However, they will work in dynamic tokens!

These are the information arguments and the values they return:
| Argument | Return Value |
| -------- | ------- |
| displayname | The character's display name in the current game language |
| gender | Male, Female, Undefined |
| birthday_season | spring, summer, fall, winter, [space if null] (note that this will return lowercase) |
| birthday_day | number from 1-28, 0 if none |
| age | 0 (adult), 1 (teen), 2 (child) |
| manners | 0 (neutral), 1 (polite), 2 (rude) |
| socialanxiety | 0 (outgoing), 1 (shy), 2 (neutral) |
| optimism | 0 (positive), 1 (negative), 2 (neutral) |
| datable | True, False |
| loveinterest | Name of love interest, [space if none] |
| haspartnerfordance | True, False |
| isinvisible | True, False |
| cansocialize | True, False |
| isdarkskinned | True, False |
| isadoptionspouse | True, False (I think it's the same as SpouseAdopts in Characters.json) |
| cangetpregnant | True, False (Same as SpouseWantsChildren in Characters.json) |
| ismarriedorengaged | True, False |
| canrecievegifts | True, False |

For example, Maru, specifically when married to a female farmer with a nursery built, would return this data for the following tokens: 
| Token | Return Value |
| -------- | ------- |
| siliconmodding.NPCTokens/NPC:Maru+displayname | Maru |
| siliconmodding.NPCTokens/NPC:Maru+gender | Female |
| siliconmodding.NPCTokens/NPC:Maru+birthday_season | summer |
| siliconmodding.NPCTokens/NPC:Maru+birthday_day | 10 |
| siliconmodding.NPCTokens/NPC:Maru+age | 1 |
| siliconmodding.NPCTokens/NPC:Maru+manners | 0 |
| siliconmodding.NPCTokens/NPC:Maru+socialanxiety | 0 |
| siliconmodding.NPCTokens/NPC:Maru+optimism | 0 |
| siliconmodding.NPCTokens/NPC:Maru+datable | True  |
| siliconmodding.NPCTokens/NPC:Maru+loveinterest | Harvey |
| siliconmodding.NPCTokens/NPC:Maru+haspartnerfordance | False |
| siliconmodding.NPCTokens/NPC:Maru+isinvisible | False |
| siliconmodding.NPCTokens/NPC:Maru+cansocialize | True |
| siliconmodding.NPCTokens/NPC:Maru+isdarkskinned | True |
| siliconmodding.NPCTokens/NPC:Maru+isadoptionspouse | True (From being married to a farmer of the same gender) |
| siliconmodding.NPCTokens/NPC:Maru+cangetpregnant | True (From having child requirements fulfilled) <br>(this will also be true for male spouses, hence<br>the other name, SpouseWantsChildren) |
| siliconmodding.NPCTokens/NPC:Maru+ismarriedorengaged | True |
| siliconmodding.NPCTokens/NPC:Maru+canrecievegifts | True |

Feel free to request any useful tokens I might've missed!

[Nexus page](https://www.nexusmods.com/stardewvalley/mods/23637)
