﻿using FizzWare.NBuilder;
using FluentAssertions;
using NUnit.Framework;
using NzbDrone.Core.Tv;
using NzbDrone.Core.Test.Framework;
using NzbDrone.Core.Tv.Events;

namespace NzbDrone.Core.Test.TvTests
{
    [TestFixture]
    public class SeriesServiceFixture : CoreTest<SeriesService>
    {
        private Series fakeSeries;

        [SetUp]
        public void Setup()
        {
            fakeSeries = Builder<Series>.CreateNew().Build();
        }

        [Test]
        public void series_added_event_should_have_proper_path()
        {
            fakeSeries.Path = null;
            fakeSeries.RootFolderPath = @"C:\Test\TV";

            var series = Subject.AddSeries(fakeSeries);

            series.Path.Should().NotBeNull();

            VerifyEventPublished<SeriesAddedEvent>();
        }

    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             