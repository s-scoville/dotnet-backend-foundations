using EnumerationsBasics.Models;
using EnumerationsBasics.Services;

var showClassMessage = new ShowClassMessage();
showClassMessage.Display(ClassType.Paladin);
showClassMessage.Display(ClassType.Mage);
showClassMessage.Display(ClassType.Rogue);