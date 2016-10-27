﻿using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Operations.Housekeeping {
    public partial class HousekeepingTimeIndicator : EntityIndicator<HousekeepingTimeIndicator> {
        public HousekeepingTimeIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}
