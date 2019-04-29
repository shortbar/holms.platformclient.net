﻿using HOLMS.Platform.Support.ReservationTags;
using HOLMS.Platform.Support.Time;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Booking.Reservations;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.Reservations {
    public class ReservationFRPAmendmentRequestBuilder {
        public ReservationFRPAmendmentRequestBuilder(
                InclusiveOpsdateRange dr,
                RoomTypeIndicator rt,
                ImmutableTagSet tags,
                ReservationIndicator ri,
                int adults,
                int children,
                bool isGroupHoldUpdateRequested) {
            DateRange = dr;
            RoomType = rt;
            Tags = tags;
            Reservation = ri;
            NumberAdults = adults;
            NumberChildren = children;
            IsGroupHoldUpdateRequested = isGroupHoldUpdateRequested;
        }

        public InclusiveOpsdateRange DateRange;
        public RoomTypeIndicator RoomType;
        public ImmutableTagSet Tags;
        public ReservationIndicator Reservation;
        public int NumberAdults;
        public int NumberChildren;
        public bool IsGroupHoldUpdateRequested;

        public ReservationFRPAmendmentRequest Build() {
            var request = new ReservationFRPAmendmentRequest() {
                Reservation = Reservation,
                RoomType = RoomType,
                DateRange = DateRange.ToPB,
                AdultGuestCount = NumberAdults,
                ChildGuestCount = NumberChildren,
                IsGroupHoldUpdateRequested = IsGroupHoldUpdateRequested
            };

            request.Tags.Add(Tags.GetDescriptors());
            
            return request;
        }
    }
}
