﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Awam.Tracker.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrackerModel;

namespace Awam.Tracker.Data.Tests
{
    [TestClass]
    public class HandsTest
    {
        [TestMethod]
        [DeploymentItem("trackDB.sdf", @"")]
        public void SaveHandsSqlCommandTest()
        {
            var hands = new List<Hand>();

            Hand hand =
                new Hand
                    {
                        BigBlind = 1,
                        ButtonPosition = 2,
                        FlopCard1 = "As",
                        FlopCard2 = "Js",
                        FlopCard3 = "Th",
                        HandId = "4545454",
                        RiverCard = "2s",
                        Time = new DateTime(2000, 1, 1),
                        TurnCard = "7s",
                        Players = new List<HandPlayer>()
                    };

            HandPlayer player =
                new HandPlayer
                    {
                        ActionFlop = "action Flop",
                        ActionPreflop = "action Preflop",
                        ActionRiver = "action River",
                        ActionTurn = "action Turn",
                        Card1Str = "2a",
                        Card2Str = "3c",
                        MyMoneyAddedInPot = 2,
                        MyMoneyCollected = 1,
                        PaidFlop = 0.5m,
                        PaidPreflop = 0.6m,
                        PaidRiver = 0.7m,
                        PaidTurn = 0.8m,
                        SeatNumber = 4,
                        Player = "player1",
                        Stack = 6.52m
                    };

            hand.Players.Add(player);
            hands.Add(hand);

            new Hands().SaveHandsSqlCommand(hands);

            using (trackDBEntities2 t = new trackDBEntities2())
            {
                Assert.AreEqual(t.Hands.Count(), 1);
                Assert.AreEqual(t.Hands.First().BB, 1);
                Assert.AreEqual(t.Hands.First().PositionButton, 2);
                Assert.AreEqual(t.Hands.First().Id, "4545454");
                Assert.AreEqual(t.Hands.First().Time, new DateTime(2000, 1, 1));
                Assert.AreEqual(t.Hands.First().Position, 4);
                Assert.AreEqual(t.Hands.First().Stack, 6.52m);
            }

        }
    }
}


