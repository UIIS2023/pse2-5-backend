﻿using Explorer.Payments.API.Dtos;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Payments.API.Internal
{
    public interface IInternalBoughtItemService
    {
        Result<BoughtItemDto> CreateBoughtItem(BoughtItemDto boughtItemDto);
    }
}
