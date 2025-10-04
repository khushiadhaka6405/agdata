using agdata.Application.Interfaces;
using agdata.Domain.Entities.Redemption;
using agdata.Infrastructure;
using System;
using System.Collections.Generic;

namespace Services
{
    public class RedemptionService : IRedemptionService
    {
        private readonly IRedemptionRepository _redemptionRepository; // repository for storing redemptions

        // Constructor with dependency injection
        public RedemptionService(IRedemptionRepository redemptionRepository)
        {
            _redemptionRepository = redemptionRepository; // inject redemption repository
        }

        // Create a new redemption
        public Redemption RedeemProduct(Guid userId, Guid productId)
        {
            // Create Redemption object using constructor
            var redemption = new Redemption(userId, productId);

            _redemptionRepository.Add(redemption); // store redemption
            return redemption; // return created redemption
        }

        // Get all redemptions
        public IEnumerable<Redemption> GetAllRedemptions()
        {
            return _redemptionRepository.GetAll(); // return all redemptions
        }

        // Get redemption by ID
        public Redemption GetRedemptionById(Guid id)
        {
            var redemption = _redemptionRepository.GetById(id); // fetch redemption
            if (redemption == null) throw new Exception("Redemption not found"); // error if not found
            return redemption; // return redemption
        }

        // Approve a redemption
        public void ApproveRedemption(Guid id)
        {
            var redemption = GetRedemptionById(id); // find redemption
            redemption.Approve(); // change status to approved
        }

        // Complete a redemption
        public void CompleteRedemption(Guid id)
        {
            var redemption = GetRedemptionById(id); // find redemption
            redemption.Complete(); // change status to completed
        }

        // Reject a redemption
        public void RejectRedemption(Guid id)
        {
            var redemption = GetRedemptionById(id); // find redemption
            redemption.Reject(); // change status to rejected
        }
    }
}
