using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using wm.website.ui.Models;

namespace wm.website.ui.Migrations
{
    [ContextType(typeof(NoticiasAppContext))]
    partial class MyFirstMigration
    {
        public override string Id
        {
            get { return "20150721043808_MyFirstMigration"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta5-13549"; }
        }
        
        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("SqlServer:DefaultSequenceName", "DefaultSequence")
                .Annotation("SqlServer:Sequence:.DefaultSequence", "'DefaultSequence', '', '1', '10', '', '', 'Int64', 'False'")
                .Annotation("SqlServer:ValueGeneration", "Sequence");
            
            builder.Entity("wm.website.ui.Models.Noticia", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("Descripcion");
                    
                    b.Property<string>("Titulo");
                    
                    b.Key("Id");
                });
        }
    }
}
