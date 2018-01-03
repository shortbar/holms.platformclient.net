﻿using HOLMS.Types.Booking.Indicators;

namespace HOLMS.Types.Folio.FSv2 {
    public partial class FolioIndicator {
        public FolioIndicator(GroupBookingIndicator gb) {
            GroupBooking = gb;
        }

        public FolioIndicator(ReservationIndicator ri) {
            Reservation = ri;
        }
    }
}
