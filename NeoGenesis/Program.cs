using NeoGenesis.Data;
using NeoGenesis.Services;
using NeoGenesis.UI;

var context = new DataContext(); 

var service = new DinosaurService(context);

