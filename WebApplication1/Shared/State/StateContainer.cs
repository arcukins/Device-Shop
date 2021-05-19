using System;
using WebApplication1.Shared.Models;

namespace WebApplication1.Shared.State
{
	public class StateContainer
	{
		private Basket basket;
		public Basket Basket 
		{
			get => basket;
			set 
				{
					basket = value;
					NotifyStateChanged();
				}
		}

		public event Action OnChange;

		public void NotifyStateChanged() => OnChange?.Invoke();
	}
}
