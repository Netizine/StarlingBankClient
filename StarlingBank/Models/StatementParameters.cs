using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using FluentValidation;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class StatementParameters.
    /// </summary>
    public class StatementParameters
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="StatementParameters"/> class from being created.
        /// </summary>
        private StatementParameters() { }
        /// <summary>
        /// Gets the builder.
        /// </summary>
        /// <value>The builder.</value>
        public static StatementParametersBuilder Builder => new StatementParametersBuilder();
        /// <summary>
        /// Class StatementParametersBuilder.
        /// </summary>
        public class StatementParametersBuilder
        {

            /// <summary>
            /// The starling client
            /// </summary>
            private StarlingClient _starlingClient;
            /// <summary>
            /// Starlings the client.
            /// </summary>
            /// <param name="starlingClient">The starling client.</param>
            /// <returns>StatementParametersBuilder.</returns>
            public StatementParametersBuilder StarlingClient(StarlingClient starlingClient)
            {
                _starlingClient = starlingClient;
                return this;
            }


            /// <summary>
            /// The account uid
            /// </summary>
            private Guid _accountUid;
            /// <summary>
            /// Accounts the uid.
            /// </summary>
            /// <param name="accountUid">The account uid.</param>
            /// <returns>StatementParametersBuilder.</returns>
            public StatementParametersBuilder AccountUid(Guid accountUid)
            {
                _accountUid = accountUid;
                return this;
            }


            /// <summary>
            /// The year
            /// </summary>
            private string _year;
            /// <summary>
            /// Years the specified year.
            /// </summary>
            /// <param name="year">The year.</param>
            /// <returns>StatementParametersBuilder.</returns>
            public StatementParametersBuilder Year(string year)
            {
                _year = year;
                return this;
            }


            /// <summary>
            /// The month
            /// </summary>
            private string _month;
            /// <summary>
            /// Monthes the specified month.
            /// </summary>
            /// <param name="month">The month.</param>
            /// <returns>StatementParametersBuilder.</returns>
            public StatementParametersBuilder Month(string month)
            {
                _month = month;
                return this;
            }

            /// <summary>
            /// The statement type
            /// </summary>
            private StatementType _statementType;
            /// <summary>
            /// Statements the type.
            /// </summary>
            /// <param name="statementType">Type of the statement.</param>
            /// <returns>StatementParametersBuilder.</returns>
            public StatementParametersBuilder StatementType(StatementType statementType)
            {
                _statementType = statementType;
                return this;
            }


            /// <summary>
            /// Builds this instance.
            /// </summary>
            /// <returns>StatementParameters.</returns>
            public StatementParameters Build()
            {
                return ValidStatementParameters();
            }
            /// <summary>
            /// Valids the statement parameters.
            /// </summary>
            /// <returns>StatementParameters.</returns>
            private StatementParameters ValidStatementParameters()
            {
                var validator = new StatementParametersValidator();
                var statementArgument = new StatementParameters
                {
                    StarlingClient = _starlingClient,
                    AccountUid = _accountUid,
                    Year = _year,
                    Month = _month,
                };
                validator.ValidateAndThrow(statementArgument);
                return statementArgument;

            }
        }

        /// <summary>
        /// Class StatementParametersValidator.
        /// Implements the <see cref="FluentValidation.AbstractValidator{StarlingBank.Models.StatementParameters}" />
        /// </summary>
        /// <seealso cref="FluentValidation.AbstractValidator{StarlingBank.Models.StatementParameters}" />
        public class StatementParametersValidator : AbstractValidator<StatementParameters>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="StatementParametersValidator"/> class.
            /// </summary>
            public StatementParametersValidator()
            {
                RuleFor(x => x.StarlingClient).NotNull();
                RuleFor(x => x.AccountUid).NotNull();
                RuleFor(x => x.Year).NotNull().NotEmpty().WithMessage("Year is required eg 2021.").MinimumLength(4).MaximumLength(4);
                RuleFor(x => x.Month).NotNull().NotEmpty().WithMessage("Month is required eg 01.").MinimumLength(2).MaximumLength(2);

            }
        }

        /// <summary>
        /// Gets the starling client.
        /// </summary>
        /// <value>The starling client.</value>
        [Required]
        public StarlingClient StarlingClient { get; private set; }

        /// <summary>
        /// Gets the account uid.
        /// </summary>
        /// <value>The account uid.</value>
        [Required]
        public Guid AccountUid { get; private set; }

        /// <summary>
        /// Gets the year.
        /// </summary>
        /// <value>The year.</value>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Year is required eg 2021.")]
        [MinLength(4)]
        [MaxLength(4)]
        public string Year { get; private set; }

        /// <summary>
        /// Gets the month.
        /// </summary>
        /// <value>The month.</value>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Month is required eg 01.")]
        [MinLength(2)]
        [MaxLength(2)]
        public string Month { get; private set; }

        /// <summary>
        /// Gets the type of the statement.
        /// </summary>
        /// <value>The type of the statement.</value>
        public StatementType StatementType { get; private set; }
    }
}
