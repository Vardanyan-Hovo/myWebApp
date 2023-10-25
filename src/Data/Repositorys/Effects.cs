using System;
using Microsoft.EntityFrameworkCore;

namespace ManipulateImages.Data.Repositorys
{
	public class Effects : IEffects
	{
        private DbContextOptions _ImagsDb;
        public Effects(DbContextOptions ImagsDb)
		{
            _ImagsDb = ImagsDb;
        }
        public async Task EffectsOne()
        {

        }

        public async Task EffectsTwo()
        {

        }
        public async Task EffectsThree()
        {

        }
    }
}

