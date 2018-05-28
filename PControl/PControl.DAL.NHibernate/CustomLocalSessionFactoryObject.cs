using System;
using System.Collections.Generic;
using NHibernate.Bytecode;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using PControl.DAL.NHibernate.Mapping.CalcBalance;
using Spring.Data.NHibernate;
using Spring.Data.NHibernate.Bytecode;

namespace PControl.DAL.NHibernate
{
    /// <summary>
    /// A custom version of <see cref="LocalSessionFactoryObject" /> that sets 
    /// bytecode provider to be Spring.NET's <see cref="BytecodeProvider" />.
    /// </summary>
    public class CustomLocalSessionFactoryObject : LocalSessionFactoryObject
    {
        /// <summary>
        /// Overwritten to return Spring's bytecode provider for entity injection to work.
        /// </summary>
        public override IBytecodeProvider BytecodeProvider
        {
            get { return new BytecodeProvider(ApplicationContext); }
            set { }
        }

        protected override void PostProcessMappings(Configuration config)
        {
            base.PostProcessMappings(config);
            // Настройка маппинга, созданного при помощи mapping-by-code
            var mapper = new ModelMapper();
            mapper.AddMappings(new List<Type>
                    {
                        // Перечень классов, описывающих маппинг
                        typeof(ProductMap),
                        typeof(BalanceMap),
                        typeof(DocumentMap),
                        typeof(DocumentDetailMap),
                    });
            // Добавление маппинга, созданного при помощи mapping-by-code, 
            // в NHibernate-конфигурацию приложения
            config.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), null);
        }
    }
}