// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IThreatAssessmentResultRequest.
    /// </summary>
    public partial interface IThreatAssessmentResultRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ThreatAssessmentResult using POST.
        /// </summary>
        /// <param name="threatAssessmentResultToCreate">The ThreatAssessmentResult to create.</param>
        /// <returns>The created ThreatAssessmentResult.</returns>
        System.Threading.Tasks.Task<ThreatAssessmentResult> CreateAsync(ThreatAssessmentResult threatAssessmentResultToCreate);        /// <summary>
        /// Creates the specified ThreatAssessmentResult using POST.
        /// </summary>
        /// <param name="threatAssessmentResultToCreate">The ThreatAssessmentResult to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ThreatAssessmentResult.</returns>
        System.Threading.Tasks.Task<ThreatAssessmentResult> CreateAsync(ThreatAssessmentResult threatAssessmentResultToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ThreatAssessmentResult.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ThreatAssessmentResult.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ThreatAssessmentResult.
        /// </summary>
        /// <returns>The ThreatAssessmentResult.</returns>
        System.Threading.Tasks.Task<ThreatAssessmentResult> GetAsync();

        /// <summary>
        /// Gets the specified ThreatAssessmentResult.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ThreatAssessmentResult.</returns>
        System.Threading.Tasks.Task<ThreatAssessmentResult> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ThreatAssessmentResult using PATCH.
        /// </summary>
        /// <param name="threatAssessmentResultToUpdate">The ThreatAssessmentResult to update.</param>
        /// <returns>The updated ThreatAssessmentResult.</returns>
        System.Threading.Tasks.Task<ThreatAssessmentResult> UpdateAsync(ThreatAssessmentResult threatAssessmentResultToUpdate);

        /// <summary>
        /// Updates the specified ThreatAssessmentResult using PATCH.
        /// </summary>
        /// <param name="threatAssessmentResultToUpdate">The ThreatAssessmentResult to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ThreatAssessmentResult.</returns>
        System.Threading.Tasks.Task<ThreatAssessmentResult> UpdateAsync(ThreatAssessmentResult threatAssessmentResultToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IThreatAssessmentResultRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IThreatAssessmentResultRequest Expand(Expression<Func<ThreatAssessmentResult, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IThreatAssessmentResultRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IThreatAssessmentResultRequest Select(Expression<Func<ThreatAssessmentResult, object>> selectExpression);

    }
}
