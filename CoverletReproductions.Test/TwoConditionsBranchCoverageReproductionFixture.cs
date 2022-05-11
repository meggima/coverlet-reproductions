﻿using System.Collections.Generic;
using Xunit;

namespace CoverletReproductions.Test;

public class TwoConditionsBranchCoverageReproductionFixture
{
    [Fact]
    public void ExecuteReproduction_HasUncoveredBranch()
    {
        // Arrange
        var sut = new TwoConditionsBranchCoverageReproduction();

        // Act
        // First condition is never true (number == 1) but both branches (return true/false) are covered by this test
        sut.ExecuteReproduction(2);
        sut.ExecuteReproduction(3);
        // Uncomment to create a test case that covers all branches
        // sut.ExecuteReproduction(1);

        // Coverage is even worse here
        sut.ExecuteReproduction2(2);
        sut.ExecuteReproduction2(3);
        // Uncomment to create a test case that covers all branches
        // sut.ExecuteReproduction2(1);

        // First condition is never true (number == 1) but both branches (return true/false) are covered by this test
        sut.ExecuteReproduction3(2);
        sut.ExecuteReproduction3(3);

        // Can be reproduces with logical AND too.
        // First condition is never false (number != null)
        sut.ExecuteReproduction4(2);
        sut.ExecuteReproduction4(3);

        sut.ExecuteReturnBoolenValue(2);
        sut.ExecuteReturnBoolenValue(3);

        // Test identical methods where the second condition is never true (number == 2)
        // This way the branch coverage is full
        sut.ExecuteSecondAssertIsNeverTrue(1);
        sut.ExecuteSecondAssertIsNeverTrue(3);

        sut.ExecuteSecondAssertIsNeverTrue2(1);
        sut.ExecuteSecondAssertIsNeverTrue2(3);

        sut.ExecuteSecondAssertIsNeverTrue3(1);
        sut.ExecuteSecondAssertIsNeverTrue3(3);

        sut.ExecuteSecondAssertIsNeverTrue4(2);
        sut.ExecuteSecondAssertIsNeverTrue4(null);

        // Assert
        // no assert
    }
}
