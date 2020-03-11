﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Character
    {
        #region ENUMERABLES

        public enum ClanType
        {
            Human,
            HalfHuman,
            Demon,
            Angel
        }

        #endregion

        #region FIELDS

        protected int _id;
        protected string _name;
        protected int _locationId;
        protected int _age;
        protected ClanType _clan;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public ClanType Clan
        {
            get { return _clan; }
            set { _clan = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, ClanType race, int locationId)
        {
            _name = name;
            _clan = race;
            _locationId = locationId;
        }

        #endregion

        #region METHODS

        public virtual string DefaultGreeting()
        {
            return $"Hello, my name is {_name} and I am part of the {_clan} clan.";
        }

        #endregion


    }
}
